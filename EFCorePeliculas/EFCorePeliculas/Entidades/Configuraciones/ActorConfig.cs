using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(a => a.Nombre)
                .HasMaxLength(150)
                .IsRequired();
            //modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento)
            //    .HasColumnType("date");

        }
    }
}
