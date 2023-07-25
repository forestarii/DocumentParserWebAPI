using DocumentParser.Api.Domain;
using DocumentParser.Api.Mapping;
using DocumentParser.Api.Repository;

namespace DocumentParser.Api.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public async Task<bool> CreateAsync(Document document)
        {
            var existingUser = await _documentRepository.GetAsync(document.Id);
            if (existingUser is not null)
            {
                var message = $"A document with id {document.Id} already exists";
                throw new InvalidOperationException(message);
            }

            var documentDto = document.ToDto();
            return await _documentRepository.CreateAsync(documentDto);
        }

        public async Task<Document?> GetAsync(Guid id)
        {
            var documentDto = await _documentRepository.GetAsync(id);
            return documentDto?.ToDomain();
        }

        public async Task<IEnumerable<Document>> GetAllAsync()
        {
            var documentDtos = await _documentRepository.GetAllAsync();
            return documentDtos.Select(x => x.ToDomain());
        }

        public async Task<bool> UpdateAsync(Document customer)
        {
            var customerDto = customer.ToDto();

            return await _documentRepository.UpdateAsync(customerDto);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _documentRepository.DeleteAsync(id);
        }
    }
}
