namespace BackEndApi.Services;

public interface IEmbeddingClient
{
    /// <summary>Embeds one or more texts in a single API call. Order matches <paramref name="inputs"/>.</summary>
    Task<IReadOnlyList<float[]>> EmbedAsync(IReadOnlyList<string> inputs, CancellationToken cancellationToken = default);
}
