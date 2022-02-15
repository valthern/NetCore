using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.Property(p => p.Titulo)
                .HasMaxLength(250)
                .IsRequired();
            //modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno)
            //    .HasColumnType("date");
            builder.Property(p => p.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
