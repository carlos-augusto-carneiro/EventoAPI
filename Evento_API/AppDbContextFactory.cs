using Evento_INFRASTRUCTURE.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Evento_API;

public class AppDbContextFactory : IDesignTimeDbContextFactory<EventoDbContext>
{
    public EventoDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<EventoDbContext>()
            .UseSqlServer(config.GetConnectionString("SQL"),
            b => b.MigrationsAssembly("Evento_INFRASTRUCTURE"));

        return new EventoDbContext(builder.Options);
    }
}
