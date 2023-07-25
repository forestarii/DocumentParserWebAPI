using DocumentParser.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocumentParser.Api.Controllers
{
    [Route("api/json")]
    [ApiController]
    public class JsonHandlerController : ControllerBase
    {
        private readonly ILogger<JsonHandlerController> _logger;
        private readonly IJsonHandlerService _jsonParser;

        public JsonHandlerController(ILogger<JsonHandlerController> logger, IJsonHandlerService jsonParser)
        {
            _logger = logger;
            _jsonParser = jsonParser;
        }

        [HttpGet]
        public async Task<string> GetJsonAsync()
        {
            var jsonUrl = "/us/en/parametric-search/1620651/all/cached/json";
            var result = await _jsonParser.GetDocumentLinksFromJson(jsonUrl);
            return result;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
