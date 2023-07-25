using DocumentParser.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace DocumentParser.Api.Database
{
    public class DataContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public string DbPath { get; }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "documents.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
