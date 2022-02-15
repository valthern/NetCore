using EFCorePeliculas.Entidades;
using EFCorePeliculas.Entidades.Configuraciones;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder) => configurationBuilder.Properties<DateTime>().HaveColumnType("date");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Genero
            modelBuilder.ApplyConfiguration(new GeneroConfig());

            // Actor
            modelBuilder.Entity<Actor>().Property(a => a.Nombre)
                .HasMaxLength(150)
                .IsRequired();
            //modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento)
            //    .HasColumnType("date");

            // Cine
            modelBuilder.Entity<Cine>().Property(c => c.Nombre)
                .HasMaxLength(150)
                .IsRequired();

            // SalaDeCine
            modelBuilder.Entity<SalaDeCine>().Property(sc => sc.Precio)
                .HasPrecision(9, 2);
            modelBuilder.Entity<SalaDeCine>().Property(sc => sc.TipoSalaDeCine)
                .HasDefaultValue(TipoSalaDeCine.DosDimensiones);

            // Pelicula
            modelBuilder.Entity<Pelicula>().Property(p => p.Titulo)
                .HasMaxLength(250)
                .IsRequired();
            //modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno)
            //    .HasColumnType("date");
            modelBuilder.Entity<Pelicula>().Property(p => p.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);

            // CineOferta
            modelBuilder.Entity<CineOferta>().Property(co => co.PorcentajeDescuento)
                .HasPrecision(5, 2);
            //modelBuilder.Entity<CineOferta>().Property(co => co.FechaInicio)
            //    .HasColumnType("date");
            //modelBuilder.Entity<CineOferta>().Property(co => co.FechaFin)
            //    .HasColumnType("date");

            // PeliculaActor
            modelBuilder.Entity<PeliculaActor>().HasKey(pa => new { pa.PeliculaId, pa.ActorId });
            modelBuilder.Entity<PeliculaActor>().Property(pa => pa.Personaje)
                .HasMaxLength(150);
        }
        
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<CineOferta> CinesOfertas { get; set; }
        public DbSet<SalaDeCine> SalasDeCine { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<PeliculaActor> PeliculasActores { get; set; }
    }
}
