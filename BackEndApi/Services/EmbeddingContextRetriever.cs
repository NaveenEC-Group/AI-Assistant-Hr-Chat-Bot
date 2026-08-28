using BackEndApi.Data;
using BackEndApi.Models;
using Microsoft.Extensions.Options;

namespace BackEndApi.Services;

public sealed class EmbeddingContextRetriever : IContextRetriever
{
    private readonly IEmbeddingClient _embeddings;
    private readonly OpenAiOptions _options;
    private readonly SemaphoreSlim _gate = new(1, 1);
    private IReadOnlyList<(DocumentChunk Chunk, float[] Vector)>? _indexed;

    public EmbeddingContextRetriever(IEmbeddingClient embeddings, IOptions<OpenAiOptions> options)
    {
        _embeddings = embeddings;
        _options = options.Value;
    }

    public async Task<IReadOnlyList<RetrievedChunk>> RetrieveAsync(string question, int topK, CancellationToken cancellationToken = default)
    {
        await EnsureIndexedAsync(cancellationToken).ConfigureAwait(false);

        var qVec = (await _embeddings.EmbedAsync([question], cancellationToken).ConfigureAwait(false))[0];
        var qNorm = L2Norm(qVec);
        if (qNorm <= 0)
            return FallbackTopK(topK);

        var scored = new List<RetrievedChunk>(_indexed!.Count);
        foreach (var (chunk, vec) in _indexed)
        {
            var dNorm = L2Norm(vec);
            if (dNorm <= 0)
                continue;
            var sim = Dot(qVec, vec) / (qNorm * dNorm);
            scored.Add(new RetrievedChunk(chunk, sim));
        }

        scored.Sort((a, b) => b.Score.CompareTo(a.Score));
        return scored.Count == 0 ? FallbackTopK(topK) : scored.Take(topK).ToList();
    }

    private async Task EnsureIndexedAsync(CancellationToken cancellationToken)
    {
        if (_indexed is not null)
            return;

        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (_indexed is not null)
                return;

            var chunks = KnowledgeBase.Chunks;
            var texts = chunks.Select(c => c.Text).ToList();
            var vectors = await _embeddings.EmbedAsync(texts, cancellationToken).ConfigureAwait(false);

            var list = new List<(DocumentChunk, float[])>(chunks.Count);
            for (var i = 0; i < chunks.Count; i++)
                list.Add((chunks[i], vectors[i]));

            _indexed = list;
        }
        finally
        {
            _gate.Release();
        }
    }

    private static IReadOnlyList<RetrievedChunk> FallbackTopK(int topK) =>
        KnowledgeBase.Chunks.Take(topK).Select(c => new RetrievedChunk(c, 0)).ToList();

    private static double Dot(float[] a, float[] b)
    {
        double s = 0;
        for (var i = 0; i < a.Length; i++)
            s += a[i] * b[i];
        return s;
    }

    private static double L2Norm(float[] v)
    {
        double s = 0;
        foreach (var x in v)
            s += x * x;
        return Math.Sqrt(s);
    }
}
