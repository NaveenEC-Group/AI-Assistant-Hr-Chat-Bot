using System.Text;
using BackEndApi.Models;

namespace BackEndApi.Services;

public sealed class AiService : IAiService
{
    private readonly IContextRetriever _retriever;
    private readonly ILlmClient _llm;
    private const int DefaultTopK = 3;
    private const double RelevanceThreshold = 0.3;

    private static readonly string[] NoDataResponses =
    [
        "I couldn't find any information related to your question in our stored documents. Please try rephrasing or ask about a different topic.",
        "Unfortunately, this data isn't available in our storage yet. If you believe it should be, please check that the relevant documents have been uploaded.",
        "I searched through the available documents but found nothing matching your query. Try asking about a topic covered in the uploaded files.",
        "No relevant information was found in the knowledge base for your question. The data you're looking for may not have been added yet.",
        "It seems we don't have any stored data related to this question. Please make sure the relevant documents are uploaded, or try a different question.",
        "I wasn't able to locate any matching content in the available documents. Could you rephrase your question or ask about something else?",
        "The information you're asking about doesn't appear to exist in our document storage. Try uploading the relevant files first, then ask again."
    ];

    public AiService(IContextRetriever retriever, ILlmClient llm)
    {
        _retriever = retriever;
        _llm = llm;
    }

    public async Task<string> AskAsync(string question)
    {
        var trimmed = question?.Trim() ?? string.Empty;
        if (trimmed.Length == 0)
            return "Please enter a question.";

        var retrieved = await _retriever.RetrieveAsync(trimmed, DefaultTopK).ConfigureAwait(false);

        var relevant = retrieved
            .Where(r => r.Score >= RelevanceThreshold)
            .ToList();

        if (relevant.Count == 0)
            return GetNoDataResponse();

        var prompt = BuildPrompt(trimmed, relevant);
        return await _llm.CompleteAsync(prompt).ConfigureAwait(false);
    }

    private static string GetNoDataResponse()
    {
        var index = Random.Shared.Next(NoDataResponses.Length);
        return NoDataResponses[index];
    }

    private static string BuildPrompt(string question, IReadOnlyList<RetrievedChunk> retrieved)
    {
        var hasFunContext = retrieved.Any(r =>
            r.Chunk.Source.Equals("fun.txt", StringComparison.OrdinalIgnoreCase));

        var sb = new StringBuilder();
        sb.AppendLine("You are a helpful assistant. Answer the user's question ONLY using the CONTEXT provided below.");
        sb.AppendLine("Do NOT make up information. If the context does not contain enough information to fully answer, ");
        sb.AppendLine("clearly state which parts you can answer and which parts are not covered in the available documents.");
        if (hasFunContext)
        {
            sb.AppendLine();
            sb.AppendLine("NOTE: Some context comes from [Source: fun.txt]. These are playful, joking 'bro'-style responses. ");
            sb.AppendLine("When you use that content, deliver it directly in the same fun, casual tone as if you are saying it yourself. ");
            sb.AppendLine("Do NOT analyze, explain, or describe it as 'the context mentions'. Just say it with the joke and the energy intact.");
        }
        sb.AppendLine();
        sb.AppendLine("CONTEXT:");
        foreach (var r in retrieved)
        {
            sb.Append($"[Source: {r.Chunk.Source}] ");
            sb.AppendLine(r.Chunk.Text);
        }
        sb.AppendLine();
        sb.Append("QUESTION: ");
        sb.AppendLine(question);
        return sb.ToString();
    }
}
