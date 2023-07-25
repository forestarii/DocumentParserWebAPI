namespace DocumentParser.Api.Contracts.Data
{
    public class DocumentDto
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public required string Name { get; init; }
        public required string Link { get; init; }
    }
}
