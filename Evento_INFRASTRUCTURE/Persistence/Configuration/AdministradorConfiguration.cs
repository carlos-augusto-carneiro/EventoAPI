using Evento_CORE.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Evento_INFRASTRUCTURE.Persistence.Configuration;

public class AdministradorConfiguration : IEntityTypeConfiguration<Administrador>
{
    public void Configure(EntityTypeBuilder<Administrador> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).
                IsRequired().
                ValueGeneratedOnAdd().
                HasColumnName("Id").
                HasColumnOrder(1);
        builder.Property(x => x.Name).
                IsRequired().
                HasColumnName("Nome").
                HasColumnOrder(2).
                HasMaxLength(64);
        builder.Property(x => x.Senha).
                IsRequired().
                HasColumnName("Senha").
                HasColumnOrder(3);
        builder.Property(x => x.Email).
                IsRequired().
                HasColumnName("Email").
                HasColumnOrder(4).
                HasMaxLength(128);
        builder.Property(x => x.Role).
               IsRequired().
               HasColumnName("Role").
               HasColumnOrder(5);
        builder.Property(x => x.DataDeCadastro).
                IsRequired();

        builder.HasMany(x => x.Evento).
                WithOne(x => x.Administrador).
                HasForeignKey(x => x.IdAdm).
                OnDelete(DeleteBehavior.Cascade);
    }
}
