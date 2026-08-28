using BackEndApi.Models;

namespace BackEndApi.Services;

public interface IContextRetriever
{
    Task<IReadOnlyList<RetrievedChunk>> RetrieveAsync(string question, int topK, CancellationToken cancellationToken = default);

    /// <summary>Builds the embedding index if needed so the first ask is faster.</summary>
    Task WarmupAsync(CancellationToken cancellationToken = default);

    bool IsReady { get; }
}
