using System.Text;
using System.Text.RegularExpressions;
using UglyToad.PdfPig;

namespace BackEndApi.Services;

public interface IDocumentTextExtractor
{
    bool IsSupported(string fileName);

    /// <summary>
    /// Extracts plain text from the uploaded document, formatted with one
    /// knowledge chunk per line (the KnowledgeBaseWriter splits on newlines).
    /// </summary>
    Task<string> ExtractAsync(string fileName, Stream stream, CancellationToken cancellationToken = default);
}

public sealed class DocumentTextExtractor : IDocumentTextExtractor
{
    private static readonly string[] SupportedExtensions = [".txt", ".md", ".pdf"];

    public bool IsSupported(string fileName)
    {
        var ext = Path.GetExtension(fileName).ToLowerInvariant();
        return SupportedExtensions.Contains(ext);
    }

    public async Task<string> ExtractAsync(string fileName, Stream stream, CancellationToken cancellationToken = default)
    {
        var ext = Path.GetExtension(fileName).ToLowerInvariant();
        return ext switch
        {
            ".pdf" => await ExtractPdfAsync(stream, cancellationToken).ConfigureAwait(false),
            _ => await ExtractTextAsync(stream).ConfigureAwait(false),
        };
    }

    private static async Task<string> ExtractTextAsync(Stream stream)
    {
        using var reader = new StreamReader(stream);
        return await reader.ReadToEndAsync().ConfigureAwait(false);
    }

    private static async Task<string> ExtractPdfAsync(Stream stream, CancellationToken cancellationToken)
    {
        using var ms = new MemoryStream();
        await stream.CopyToAsync(ms, cancellationToken).ConfigureAwait(false);
        ms.Position = 0;

        var raw = new StringBuilder();
        using (var document = PdfDocument.Open(ms))
        {
            foreach (var page in document.GetPages())
            {
                cancellationToken.ThrowIfCancellationRequested();
                raw.Append(page.Text).Append(' ');
            }
        }

        var normalized = Regex.Replace(raw.ToString(), @"\s+", " ").Trim();
        if (normalized.Length == 0)
            return string.Empty;

        var sentences = Regex.Split(normalized, @"(?<=[.!?])\s+")
            .Select(s => s.Trim())
            .Where(s => s.Length > 0);

        return string.Join("\n", sentences);
    }
}
