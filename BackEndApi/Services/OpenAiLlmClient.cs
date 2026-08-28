using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;

namespace BackEndApi.Services;

public sealed class OpenAiLlmClient(HttpClient http, IOptions<OpenAiOptions> options) : ILlmClient
{
    private readonly OpenAiOptions _options = options.Value;

    public async Task<string> CompleteAsync(string prompt, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(_options.ApiKey))
            throw new InvalidOperationException(
                "OpenAI API key is missing. Set OpenAI:ApiKey in user secrets (dotnet user-secrets) or environment variable OpenAI__ApiKey.");

        using var request = new HttpRequestMessage(HttpMethod.Post, "chat/completions");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _options.ApiKey.Trim());
        request.Content = JsonContent.Create(new
        {
            model = _options.Model,
            messages = new[] { new { role = "user", content = prompt } },
            temperature = 0.2,
        });

        using var response = await http.SendAsync(request, cancellationToken).ConfigureAwait(false);
        var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
            throw new InvalidOperationException($"OpenAI API error {(int)response.StatusCode}: {body}");

        using var doc = JsonDocument.Parse(body);
        var root = doc.RootElement;
        if (root.TryGetProperty("error", out var err))
        {
            var msg = err.TryGetProperty("message", out var m) ? m.GetString() : body;
            throw new InvalidOperationException($"OpenAI error: {msg}");
        }

        return root.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString()
               ?? string.Empty;
    }
}
