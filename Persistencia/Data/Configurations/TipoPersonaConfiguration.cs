using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("TipoPersona");

        builder.Property(tp => tp.Id)            
            .HasColumnName("idTIpoPersona")
            .IsRequired()            
            .HasMaxLength(12);

        builder.Property(tp => tp.Descripcion)            
            .HasColumnName("desciptionTIpoPersona")
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);
    }
}