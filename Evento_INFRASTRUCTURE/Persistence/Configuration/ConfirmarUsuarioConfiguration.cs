using Evento_CORE.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Evento_INFRASTRUCTURE.Persistence.Configuration;

public class ConfirmarUsuarioConfiguration : IEntityTypeConfiguration<ConfirmarUsuario>
{
    public void Configure(EntityTypeBuilder<ConfirmarUsuario> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasOne(c => c.Usuario)
            .WithMany(u => u.Confirmacoes)
            .HasForeignKey(c => c.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Evento)
            .WithMany(e => e.Confirmacoes)
            .HasForeignKey(c => c.IdEvento)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
