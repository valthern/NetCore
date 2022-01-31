using EFCorePeliculas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Genero
            modelBuilder.Entity<Genero>().HasKey(g => g.Identificador);
            modelBuilder.Entity<Genero>().Property(g => g.Nombre)
                //.HasColumnName("NombreGenero")
                .HasMaxLength(150)
                .IsRequired();
            //modelBuilder.Entity<Genero>().ToTable(name: "TablaGeneros", schema: "Peliculas");

            // Actor
            modelBuilder.Entity<Actor>().Property(a => a.Nombre)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento)
                .HasColumnType("date");

            // Cine
            modelBuilder.Entity<Cine>().Property(c => c.Nombre)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Cine>().Property(c => c.Precio)
                .HasPrecision(9, 2);

            // Pelicula
            modelBuilder.Entity<Pelicula>().Property(p => p.Titulo)
                .HasMaxLength(250)
                .IsRequired();
            modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno)
                .HasColumnType("date");
            modelBuilder.Entity<Pelicula>().Property(p => p.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);

            // CineOferta
            modelBuilder.Entity<CineOferta>().Property(co => co.PorcentajeDescuento)
                .HasPrecision(5, 2);
            modelBuilder.Entity<CineOferta>().Property(co => co.FechaInicio)
                .HasColumnType("date");
            modelBuilder.Entity<CineOferta>().Property(co => co.FechaFin)
                .HasColumnType("date");
        }
        
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<CineOferta> CinesOfertas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
    }

}