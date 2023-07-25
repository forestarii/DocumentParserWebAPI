using DocumentParser.Api.Repository;
using DocumentParser.Api.Services;

namespace DocumentParser.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var config = builder.Configuration;
            config.AddEnvironmentVariables("DocumentsApi_");

            builder.Services.AddControllers(); 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IJsonHandlerService, JsonHandlerService>();
            builder.Services.AddSingleton<IDocumentRepository, DocumentRepository>();
            builder.Services.AddSingleton<IDocumentService, DocumentService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}