using DocumentParser.Api.Contracts.Data;
using DocumentParser.Api.Database;
using DocumentParser.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DocumentParser.Api.Repository
{
    public class DocumentRepository : IDocumentRepository
    {
        public async Task<bool> CreateAsync(DocumentDto document)
        {
            using var db = new DataContext();
            await db.Documents.AddAsync(document.ToDomain());
            db.SaveChanges();
            return db.Documents.Contains(document.ToDomain());
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            using var db = new DataContext();
            
            var document = await db.Documents.FirstOrDefaultAsync(d => d.Id == id);
            db.Documents.Remove(document);
            db.SaveChanges();
            return db.Documents.Contains(document);
        }

        public async Task<List<DocumentDto>> GetAllAsync()
        {
            using var db = new DataContext();
            var result = new List<DocumentDto>();
            var documents = await db.Documents.ToListAsync();
            foreach (var document in documents)
            {
                result.Add(document.ToDto());
            }
            return result;
        }

        public async Task<DocumentDto?> GetAsync(Guid id)
        {
            using var db = new DataContext();
            var result = await db.Documents.FirstOrDefaultAsync(d => d.Id == id);
            return result.ToDto();
        }

        public async Task<bool> UpdateAsync(DocumentDto document)
        {
            using var db = new DataContext();
            var result = await db.Documents.FirstOrDefaultAsync(d => d.Id == document.Id);
            
            result.Link = document.ToDomain().Link;
            result.Name = document.ToDomain().Name;

            return await db.Documents.ContainsAsync(document.ToDomain()); 
        }
    }
}
