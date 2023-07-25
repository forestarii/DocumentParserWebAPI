namespace DocumentParser.Api.Services
{
    public interface IJsonHandlerService
    {
        public Task<string> GetDocumentLinksFromJson(string url);
    }
}
