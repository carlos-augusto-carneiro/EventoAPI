using Evento_CORE.Entitys;
using Evento_INFRASTRUCTURE.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
namespace Evento_INFRASTRUCTURE.Persistence;

public class EventoDbContext : DbContext
{
    public EventoDbContext(DbContextOptions<EventoDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Administrador> Administradors { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<ConfirmarUsuario> ConfirmarUsuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new AdministradorConfiguration());
        modelBuilder.ApplyConfiguration(new EventoConfiguration());
        modelBuilder.ApplyConfiguration(new ConfirmarUsuarioConfiguration());
    }
}
