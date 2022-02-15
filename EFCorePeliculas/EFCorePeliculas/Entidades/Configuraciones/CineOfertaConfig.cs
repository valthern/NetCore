using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class CineOfertaConfig : IEntityTypeConfiguration<CineOferta>
    {
        public void Configure(EntityTypeBuilder<CineOferta> builder)
        {
            builder.Property(co => co.PorcentajeDescuento)
                .HasPrecision(5, 2);
            //modelBuilder.Entity<CineOferta>().Property(co => co.FechaInicio)
            //    .HasColumnType("date");
            //modelBuilder.Entity<CineOferta>().Property(co => co.FechaFin)
            //    .HasColumnType("date");
        }
    }
}
