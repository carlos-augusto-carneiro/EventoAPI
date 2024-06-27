using Evento_CORE.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Evento_INFRASTRUCTURE.Persistence.Configuration;

public class EventoConfiguration : IEntityTypeConfiguration<Evento>
{
    public void Configure(EntityTypeBuilder<Evento> builder)
    {
        builder.HasKey(e => e.Id); // Definindo a chave primária

        builder.Property(e => e.NameEvent).
            IsRequired().
            HasColumnName("Nome").
            ValueGeneratedOnAdd().
            HasColumnOrder(1).
            HasMaxLength(200);

        builder.Property(e => e.Descricao).
            IsRequired().
            HasColumnName("Descricao").
            HasColumnOrder(2).
            HasMaxLength(1000);

        builder.Property(e => e.DataCriacao).
            IsRequired().
            HasColumnName("Data").
            HasColumnOrder(3);

        builder.Property(e => e.MaxConvidados).
            IsRequired().
            HasColumnName("Convidados").
            HasColumnOrder(4);

        builder.Property(e => e.Status).
            IsRequired().
            HasColumnName("Status").
            HasColumnOrder(5);

        builder.Property(e => e.Preco).
            IsRequired().
            HasColumnName("Preco").
            HasColumnOrder(6);


        builder.HasOne(e => e.Administrador).
            WithMany(a => a.Evento).
            HasForeignKey(e => e.IdAdm).
            OnDelete(DeleteBehavior.Cascade);
    }
}
