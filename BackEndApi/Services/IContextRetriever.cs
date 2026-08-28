using BackEndApi.Models;

namespace BackEndApi.Services;

public interface IContextRetriever
{
    Task<IReadOnlyList<RetrievedChunk>> RetrieveAsync(string question, int topK, CancellationToken cancellationToken = default);
}
