using DocumentParser.Api.Domain;

namespace DocumentParser.Api.Services
{
    public interface IDocumentService
    {
        Task<bool> CreateAsync(Document document);

        Task<Document?> GetAsync(Guid id);

        Task<IEnumerable<Document>> GetAllAsync();

        Task<bool> UpdateAsync(Document document);

        Task<bool> DeleteAsync(Guid id);
    }
}
