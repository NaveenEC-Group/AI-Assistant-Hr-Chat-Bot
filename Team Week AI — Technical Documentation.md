# Team Week AI — Technical Documentation

> Internal knowledge-base assistant (RAG) with an ASP.NET Core API and an Angular chat UI.
> The application is branded in the UI as **"EC-Group Smart AI"**.

---

## 1. Overview

Team Week AI is a Retrieval-Augmented Generation (RAG) chat assistant that answers
questions about company policies, FAQs, holidays, insurance, office facilities, and
similar internal topics.

The flow is:

1. The user asks a question in the Angular chat UI.
2. The API embeds the question and retrieves the most relevant text chunks from the
   knowledge base using cosine similarity.
3. The relevant chunks are injected into a prompt and sent to an OpenAI chat model.
4. The model's answer is returned to the UI.

The knowledge base is seeded from a compiled C# list and can be extended at runtime by
uploading `.txt`, `.md`, or `.pdf` documents.

---

## 2. Solution structure

```
Team Week AI/
├─ BackEndApi/                 # ASP.NET Core (.NET 8) Web API
│  ├─ Controllers/
│  │  └─ AiController.cs        # /api/ai/ask, /api/ai/upload
│  ├─ Data/
│  │  └─ KnowledgeBase.cs       # Seed DocumentChunk list (compiled)
│  ├─ Models/
│  │  ├─ DocumentChunk.cs       # (Id, Source, Text)
│  │  └─ RetrievedChunk.cs      # (Chunk, Score)
│  ├─ Services/
│  │  ├─ AiService.cs           # RAG orchestration
│  │  ├─ IAiService.cs
│  │  ├─ EmbeddingContextRetriever.cs  # cosine-similarity retrieval
│  │  ├─ IContextRetriever.cs
│  │  ├─ OpenAiLlmClient.cs     # chat/completions call
│  │  ├─ ILlmClient.cs
│  │  ├─ OpenAiEmbeddingClient.cs  # embeddings call
│  │  ├─ IEmbeddingClient.cs
│  │  ├─ OpenAiOptions.cs       # config (ApiKey, Model, EmbeddingModel)
│  │  ├─ KnowledgeBaseWriter.cs # appends uploaded chunks into KnowledgeBase.cs
│  │  └─ DocumentTextExtractor.cs  # txt/md/pdf text extraction
│  └─ Program.cs                # DI registrations & pipeline
│
└─ FrontEndProject/            # Angular (module-based) chat UI
   ├─ public/assets/           # static images (e.g. velmurugan.png)
   ├─ proxy.conf.json          # /api -> http://localhost:5163
   └─ src/app/
      ├─ app.html / app.css    # header shell ("EC-Group Smart AI")
      ├─ Chat/chat/            # chat component (ask, voice, upload, image)
      └─ services/ai-service.ts# HTTP calls to the API
```

---

## 3. Backend (BackEndApi)

### 3.1 Tech stack
- ASP.NET Core Web API, target framework **net8.0**.
- Swashbuckle/Swagger (enabled in Development).
- `UglyToad.PdfPig` **0.1.14** for PDF text extraction.
- OpenAI HTTP API for chat completions and embeddings.

### 3.2 Configuration (`OpenAiOptions`)
Bound from the `OpenAI` configuration section.

| Property         | Default                    | Notes                                   |
|------------------|----------------------------|-----------------------------------------|
| `ApiKey`         | `""`                       | Required. Set via user secrets or env.  |
| `Model`          | `gpt-4o-mini`              | Chat completion model.                  |
| `EmbeddingModel` | `text-embedding-3-small`   | Embedding model for retrieval.          |

Set the API key without committing secrets:

```bash
# from the BackEndApi folder
dotnet user-secrets set "OpenAI:ApiKey" "sk-..."
# or via environment variable
setx OpenAI__ApiKey "sk-..."
```

### 3.3 Request pipeline & DI (`Program.cs`)
- `OpenAiLlmClient` and `OpenAiEmbeddingClient` are registered as typed `HttpClient`s
  with `BaseAddress = https://api.openai.com/v1/` and a 2-minute timeout.
- `IContextRetriever` → `EmbeddingContextRetriever` (singleton).
- `IKnowledgeBaseWriter` → `KnowledgeBaseWriter` (singleton).
- `IDocumentTextExtractor` → `DocumentTextExtractor` (singleton).
- `IAiService` → `AiService` (scoped).

### 3.4 RAG flow (`AiService`)
Key constants:
- `DefaultTopK = 3` — number of chunks retrieved.
- `RelevanceThreshold = 0.3` — minimum cosine similarity to be considered relevant.

Steps in `AskAsync(question)`:
1. Trim/validate the question (empty → "Please enter a question.").
2. Retrieve top-K chunks via the retriever.
3. Filter by `Score >= 0.3`. If none remain → return a random "no data" message.
4. Build a prompt with the relevant chunks as CONTEXT and send to the LLM.

Prompt note: when any retrieved chunk has `Source == "fun.txt"`, an extra instruction
is added so the model replies in the playful "bro"-style tone directly instead of
analyzing it.

### 3.5 Retrieval (`EmbeddingContextRetriever`)
- On first use it embeds **all** `KnowledgeBase.Chunks` once and caches the vectors
  (guarded by a `SemaphoreSlim`).
- For each query it embeds the question and ranks chunks by cosine similarity
  (`dot / (‖q‖·‖d‖)`), returning the top-K.
- Because the index is built once at startup, **newly appended chunks require an API
  restart** to be embedded and become searchable.

### 3.6 Knowledge base (`KnowledgeBase.cs`)
- A compiled `IReadOnlyList<DocumentChunk>` seeded with FAQ/policy/office content,
  plus a `fun.txt` easter-egg section and an employee profile section.
- `SourceFilePath()` returns this file's own absolute path on the build machine via an
  internal `[CallerFilePath]` helper (`ResolveOwnPath`). It must be resolved from inside
  this file — `[CallerFilePath]` captures the **caller's** path, not the definition's.

### 3.7 Document upload
- `DocumentTextExtractor` supports `.txt`, `.md`, `.pdf`.
  - txt/md: read raw (one knowledge chunk per non-empty line).
  - pdf: extract page text with PdfPig, normalize whitespace, split into sentences
    (one chunk per sentence). Only text-based PDFs work; scanned/image PDFs yield no text.
- `KnowledgeBaseWriter.AppendDocumentAsync` inserts new `DocumentChunk(...)` entries into
  `KnowledgeBase.cs` immediately before the closing `];`, with IDs `upload-<name>-N`.
  - This edits compiled source, so changes take effect only after a rebuild/restart.
  - It relies on the source file being present, so it works in local development but not
    on a published server where the `.cs` source is absent.

### 3.8 API endpoints (`AiController`, route `api/ai`)

| Method | Route             | Body                              | Response |
|--------|-------------------|-----------------------------------|----------|
| POST   | `/api/ai/ask`     | JSON string (the question)        | `text/plain` answer |
| POST   | `/api/ai/upload`  | multipart `file` (.txt/.md/.pdf)  | `{ added, message }` |

`/api/ai/upload` rejects empty files and unsupported extensions, extracts text, appends
chunks, and reports how many entries were added (with a reminder to restart the API).

---

## 4. Frontend (FrontEndProject)

### 4.1 Tech stack
- Angular (module-based; `standalone: false` components).
- `provideHttpClient` + `FormsModule`.
- Dev server port **54582**, with a proxy in `proxy.conf.json` routing `/api` to
  `http://localhost:5163`.

### 4.2 AiService (`services/ai-service.ts`)
- `ask(question)` → `POST /api/ai/ask` with `responseType: 'text'`.
- `uploadDocument(file)` → `POST /api/ai/upload` as `FormData`.

### 4.3 Chat component (`Chat/chat/`)
- **Ask**: sends the question, shows a typing indicator, appends the answer.
- **Voice-to-text**: uses the browser Web Speech API
  (`SpeechRecognition`/`webkitSpeechRecognition`, `en-US`). The mic button only appears
  when supported (Chrome/Edge); recognized speech streams into the input box.
- **Document upload**: paperclip button opens a file picker (`.txt,.md,.pdf`); the result
  message is posted into the chat.
- **Friend image**: when an answer matches `/velmurugan/i`, the chat renders
  `assets/velmurugan.png` under the message; hides gracefully if the image is missing.

### 4.4 UI / theming
- Global tokens live in `src/styles.css` (`:root` CSS variables).
- Cohesive indigo/violet palette: gradient header bar, soft indigo/violet background
  glows; the green avatar denotes the "You" sender.
- Header title and browser tab title are **"EC-Group Smart AI"**.
- Note: `angular.json` raises the `anyComponentStyle` budget (warning 8 kB / error 16 kB)
  to accommodate the chat component styles.

---

## 5. Running locally

### Backend
```bash
cd BackEndApi
dotnet user-secrets set "OpenAI:ApiKey" "sk-..."   # one-time
dotnet run                                          # listens on http://localhost:5163
```

### Frontend
```bash
cd FrontEndProject
npm install
npm start            # ng serve on http://localhost:54582, proxies /api to :5163
```

Open `http://localhost:54582` and start chatting.

---

## 6. Operational notes & limitations

- **Restart required after upload**: uploaded chunks are written into `KnowledgeBase.cs`
  (compiled) and the retrieval index is built once at startup, so the API must be
  rebuilt/restarted before new content is searchable.
- **Local-only upload persistence**: appending to source code only works where the `.cs`
  files exist (development), not on a published deployment.
- **PDF**: only text-based PDFs are supported; scanned/image PDFs need OCR (not included).
- **Voice input**: supported in Chromium browsers; requires mic permission and network.
- **Secrets**: never commit the OpenAI API key; use user secrets or environment variables.

---

## 7. Possible future improvements

- Move the knowledge base to a database or vector store and re-index incrementally
  (so uploads take effect without a restart and work in production).
- Add OCR for scanned PDFs and parsing for `.docx`.
- Add authentication and per-user/per-tenant knowledge bases.
- Configure CORS explicitly if the frontend is served from a different origin than the proxy.
