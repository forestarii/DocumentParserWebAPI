using DocumentParser.Api.Contracts.Data;
using DocumentParser.Api.Domain;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace DocumentParser.Api.Services
{
    public class JsonHandlerService : IJsonHandlerService
    {
        private readonly ILogger<JsonHandlerService> logger;
        private readonly IDocumentService _documentService;
        private HttpClient httpClient;
        

        public JsonHandlerService(ILogger<JsonHandlerService> logger, IDocumentService documentService)
        {
            this.logger = logger;
            this._documentService = documentService;
            InitialiseHttpClient();
        }

        public async Task<string> GetDocumentLinksFromJson(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException("Url is null or has white space!");

            using HttpResponseMessage response = await this.httpClient.GetAsync(url);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var regex = new Regex("<a [^>]*href=(?:'(?<href>.*?)')|(?:\"(?<href>.*?)\")", RegexOptions.IgnoreCase);

            Root root = JsonConvert.DeserializeObject<Root>(jsonResponse);
            var documentLinks = new List<string>();
            var documents = new List<Document>();

            foreach (var row in root.Rows)
            {
                var data = regex.Matches(row).OfType<Match>().Select(m => m.Groups["href"].Value);
                documentLinks.AddRange(data.Where(d => d.Contains("/us/en") && !documentLinks.Contains(d)));
                documents.Add(new Document { Name = data.FirstOrDefault(d => d.Contains("SLG4")), Link = string.Concat(httpClient.BaseAddress, documentLinks.FirstOrDefault(d => d.Contains("document")).Remove(0, 1))});
            }

            await this.AddToDbAsync(documents);
            return jsonResponse;
        }

        private void InitialiseHttpClient()
        {
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.renesas.com")
            };
        }

        private async Task AddToDbAsync(List<Document> collection)
        {
            foreach (var item in collection)
            {
                await _documentService.CreateAsync(item);
            }
        }
    }
}
