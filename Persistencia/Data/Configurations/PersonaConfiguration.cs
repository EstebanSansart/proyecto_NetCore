using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona");
            builder.Property(p => p.Id)
                .HasColumnName("idPersona")                
                .HasMaxLength(12)
                .IsRequired();

            builder.Property(p => p.Nombre)
                .HasColumnName("nombrePersona")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();;

            builder.Property(p => p.ApellidoPersona)
                .HasColumnName("apellidoPersona")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();;

            builder.Property(p => p.EdadPersona)
                .HasColumnName("edadPersona")                
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(p => p.IdProv)
                .HasColumnName("idProv")                
                .HasMaxLength(12)
                .IsRequired();

            builder.Property(p => p.IdTipoPer)
                .HasColumnName("idTipPer")
                .HasMaxLength(12)
                .IsRequired();

            builder.HasOne(p => p.Provincia)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdProv);

            builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdTipoPer);
        }
    }
}