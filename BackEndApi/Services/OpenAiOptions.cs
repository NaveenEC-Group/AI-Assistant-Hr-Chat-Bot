namespace BackEndApi.Services;

public sealed class OpenAiOptions
{
    public const string SectionName = "OpenAI";

    public string ApiKey { get; set; } = string.Empty;

    public string Model { get; set; } = "gpt-4o-mini";

    /// <summary>OpenAI embedding model for vector RAG (e.g. text-embedding-3-small).</summary>
    public string EmbeddingModel { get; set; } = "text-embedding-3-small";
}
