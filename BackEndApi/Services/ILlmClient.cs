namespace BackEndApi.Services;

/// <summary>Turns a prompt (context + question) into an answer via <see cref="OpenAiLlmClient"/>.</summary>
public interface ILlmClient
{
    Task<string> CompleteAsync(string prompt, CancellationToken cancellationToken = default);
}
