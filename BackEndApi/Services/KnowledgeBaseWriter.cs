using System.Text;
using System.Text.RegularExpressions;
using BackEndApi.Data;

namespace BackEndApi.Services;

public interface IKnowledgeBaseWriter
{
    Task<int> AppendDocumentAsync(string fileName, string content, CancellationToken cancellationToken = default);
}

/// <summary>
/// Appends uploaded document text into KnowledgeBase.cs as new DocumentChunk entries.
/// NOTE: KnowledgeBase.cs is compiled source. Appended entries only take effect after
/// the API is rebuilt and restarted.
/// </summary>
public sealed class KnowledgeBaseWriter : IKnowledgeBaseWriter
{
    private readonly SemaphoreSlim _gate = new(1, 1);

    public async Task<int> AppendDocumentAsync(string fileName, string content, CancellationToken cancellationToken = default)
    {
        var chunks = ExtractChunks(content);
        if (chunks.Count == 0)
            return 0;

        var sourcePath = KnowledgeBase.SourceFilePath();
        if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
            throw new FileNotFoundException("KnowledgeBase source file could not be located.", sourcePath);

        var sourceName = SanitizeSourceName(fileName);
        var idPrefix = "upload-" + sourceName;

        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            var fileText = await File.ReadAllTextAsync(sourcePath, cancellationToken).ConfigureAwait(false);

            var terminator = fileText.LastIndexOf("];", StringComparison.Ordinal);
            if (terminator < 0)
                throw new InvalidOperationException("Could not locate the chunk list terminator ('];') in KnowledgeBase.cs.");

            var insertAt = terminator;
            while (insertAt > 0 && char.IsWhiteSpace(fileText[insertAt - 1]))
                insertAt--;

            var existingCount = CountExistingUploads(fileText, idPrefix);

            var sb = new StringBuilder();
            sb.Append(',');
            sb.Append("\r\n\r\n        /* ── Uploaded: ").Append(sourceName)
              .Append(" (").Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm")).Append(") ── */");

            for (var i = 0; i < chunks.Count; i++)
            {
                var id = $"{idPrefix}-{existingCount + i + 1}";
                var source = sourceName + ".txt";
                sb.Append("\r\n        ")
                  .Append($"new DocumentChunk(\"{Escape(id)}\", \"{Escape(source)}\", \"{Escape(chunks[i])}\")");
                if (i < chunks.Count - 1)
                    sb.Append(',');
            }

            var updated = fileText.Insert(insertAt, sb.ToString());
            await File.WriteAllTextAsync(sourcePath, updated, cancellationToken).ConfigureAwait(false);

            return chunks.Count;
        }
        finally
        {
            _gate.Release();
        }
    }

    private static List<string> ExtractChunks(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            return [];

        return content
            .Replace("\r\n", "\n")
            .Split('\n')
            .Select(line => Regex.Replace(line, @"\s+", " ").Trim())
            .Where(line => line.Length > 0)
            .ToList();
    }

    private static int CountExistingUploads(string fileText, string idPrefix)
    {
        var pattern = $"\"{Regex.Escape(idPrefix)}-(\\d+)\"";
        var max = 0;
        foreach (Match m in Regex.Matches(fileText, pattern))
        {
            if (int.TryParse(m.Groups[1].Value, out var n) && n > max)
                max = n;
        }
        return max;
    }

    private static string SanitizeSourceName(string fileName)
    {
        var name = Path.GetFileNameWithoutExtension(fileName);
        if (string.IsNullOrWhiteSpace(name))
            name = "document";

        name = Regex.Replace(name, @"[^a-zA-Z0-9]+", "-").Trim('-').ToLowerInvariant();
        return string.IsNullOrEmpty(name) ? "document" : name;
    }

    private static string Escape(string text) =>
        text.Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\r", " ")
            .Replace("\n", " ")
            .Replace("\t", " ");
}
