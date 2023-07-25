using DocumentParser.Api.Contracts.Data;

namespace DocumentParser.Api.Repository
{
    public interface IDocumentRepository
    {
        Task<bool> CreateAsync(DocumentDto document);

        Task<DocumentDto?> GetAsync(Guid id);

        Task<List<DocumentDto>> GetAllAsync();

        Task<bool> UpdateAsync(DocumentDto document);

        Task<bool> DeleteAsync(Guid id);
    }
}
