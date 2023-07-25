using DocumentParser.Api.Contracts.Data;
using DocumentParser.Api.Domain;

namespace DocumentParser.Api.Mapping
{
    public static class DomainToDto
    {
        public static DocumentDto ToDto(this Document document)
        {
            if (document == null)
            {
                return null;
            }
            return new DocumentDto
            {
                Id = document.Id,
                Name = document.Name,
                Link = document.Link
            };
        }
    }
}
