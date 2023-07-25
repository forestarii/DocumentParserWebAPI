using DocumentParser.Api.Contracts.Data;
using DocumentParser.Api.Domain;

namespace DocumentParser.Api.Mapping
{
    public static class DtoToDomain
    {
        public static Document ToDomain(this DocumentDto document)
        {
            return new Document
            {
                Id = document.Id,
                Name = document.Name,
                Link = document.Link
            };
        }
    }
}
