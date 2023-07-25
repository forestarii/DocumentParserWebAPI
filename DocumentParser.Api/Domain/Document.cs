namespace DocumentParser.Api.Domain
{
    public class Document
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public required string Link { get; set; }
    }
}
