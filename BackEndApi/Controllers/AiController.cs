using BackEndApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEndApi.Controllers
{
    [ApiController]
    [Route("api/ai")]
    public class AiController : ControllerBase
    {
        private readonly IAiService _aiService;
        private readonly IContextRetriever _retriever;
        private readonly IKnowledgeBaseWriter _kbWriter;
        private readonly IDocumentTextExtractor _extractor;

        public AiController(
            IAiService aiService,
            IContextRetriever retriever,
            IKnowledgeBaseWriter kbWriter,
            IDocumentTextExtractor extractor)
        {
            _aiService = aiService;
            _retriever = retriever;
            _kbWriter = kbWriter;
            _extractor = extractor;
        }

        /// <summary>
        /// Wakes the host and builds the embedding index so the first ask is faster.
        /// </summary>
        [HttpGet("warmup")]
        public async Task<IActionResult> Warmup(CancellationToken cancellationToken)
        {
            await _retriever.WarmupAsync(cancellationToken).ConfigureAwait(false);
            return Ok(new { ready = _retriever.IsReady });
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask([FromBody] string question)
        {
            var result = await _aiService.AskAsync(question);
            return Ok(result);
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file is null || file.Length == 0)
                return BadRequest("No file uploaded.");

            if (!_extractor.IsSupported(file.FileName))
                return BadRequest("Only .txt, .md, and .pdf files are supported.");

            int added;
            try
            {
                string content;
                using (var stream = file.OpenReadStream())
                {
                    content = await _extractor.ExtractAsync(file.FileName, stream);
                }

                added = await _kbWriter.AppendDocumentAsync(file.FileName, content);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Failed to update knowledge base: {ex.Message}");
            }

            if (added == 0)
                return BadRequest("No usable text was found in the document.");

            return Ok(new
            {
                added,
                message = $"Added {added} entr{(added == 1 ? "y" : "ies")} to KnowledgeBase.cs. " +
                          "Rebuild/restart the API for the new data to become searchable."
            });
        }
    }
}
