using DocumentParser.Api.Domain;
using DocumentParser.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocumentParser.Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DocumentController: ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpPost("document/new")]
        public async Task<IActionResult> Create([FromBody] Document document)
        {
            await _documentService.CreateAsync(document);

            return CreatedAtAction("Get", new { document.Id }, document);
        }

        [HttpGet("document/{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var document = await _documentService.GetAsync(id);

            if (document is null)
            {
                return NotFound();
            }

            return Ok(document);
        }

        [HttpGet("document/all")]
        public async Task<IActionResult> GetAll()
        {
            var documents = await _documentService.GetAllAsync();
            return Ok(documents);
        }

        [HttpPut("document/{id:guid}")]
        public async Task<IActionResult> Update(
            [FromBody] Document request)
        {
            var existingDocument = await _documentService.GetAsync(request.Id);

            if (existingDocument is null)
            {
                return NotFound();
            }

            await _documentService.UpdateAsync(existingDocument);

            return Ok(existingDocument);
        }

        [HttpDelete("/{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deleted = await _documentService.DeleteAsync(id);
            if (!deleted)
            {
                return NotFound();
            }

            return Ok();
        }

    }
}
