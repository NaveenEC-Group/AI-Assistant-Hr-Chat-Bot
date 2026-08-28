using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;

namespace BackEndApi.Services;

public sealed class OpenAiEmbeddingClient(HttpClient http, IOptions<OpenAiOptions> options) : IEmbeddingClient
{
    private readonly OpenAiOptions _options = options.Value;

    public async Task<IReadOnlyList<float[]>> EmbedAsync(IReadOnlyList<string> inputs, CancellationToken cancellationToken = default)
    {
        if (inputs.Count == 0)
            return [];

        if (string.IsNullOrWhiteSpace(_options.ApiKey))
            throw new InvalidOperationException(
                "OpenAI API key is missing. Set OpenAI:ApiKey in user secrets (dotnet user-secrets) or environment variable OpenAI__ApiKey.");

        using var request = new HttpRequestMessage(HttpMethod.Post, "embeddings");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _options.ApiKey.Trim());
        request.Content = JsonContent.Create(new
        {
            model = _options.EmbeddingModel,
            input = inputs.ToArray(),
        });

        using var response = await http.SendAsync(request, cancellationToken).ConfigureAwait(false);
        var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
            throw new InvalidOperationException($"OpenAI embeddings error {(int)response.StatusCode}: {body}");

        using var doc = JsonDocument.Parse(body);
        var root = doc.RootElement;
        if (root.TryGetProperty("error", out var err))
        {
            var msg = err.TryGetProperty("message", out var m) ? m.GetString() : body;
            throw new InvalidOperationException($"OpenAI error: {msg}");
        }

        if (!root.TryGetProperty("data", out var data) || data.ValueKind != JsonValueKind.Array)
            throw new InvalidOperationException("OpenAI embeddings response missing data array.");

        var byIndex = new float[inputs.Count][];
        foreach (var item in data.EnumerateArray())
        {
            if (!item.TryGetProperty("index", out var idxEl) || idxEl.ValueKind != JsonValueKind.Number)
                continue;
            var idx = idxEl.GetInt32();
            if ((uint)idx >= (uint)inputs.Count)
                continue;
            if (!item.TryGetProperty("embedding", out var emb) || emb.ValueKind != JsonValueKind.Array)
                continue;
            var vec = new float[emb.GetArrayLength()];
            var i = 0;
            foreach (var n in emb.EnumerateArray())
            {
                if (n.ValueKind == JsonValueKind.Number)
                    vec[i++] = (float)n.GetDouble();
            }

            if (i != vec.Length)
                Array.Resize(ref vec, i);
            byIndex[idx] = vec;
        }

        for (var i = 0; i < byIndex.Length; i++)
        {
            if (byIndex[i] is null || byIndex[i].Length == 0)
                throw new InvalidOperationException($"OpenAI embeddings response missing vector for index {i}.");
        }

        return byIndex;
    }
}
