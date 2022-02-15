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
            modelBuilder.ApplyConfiguration(new ActorConfig());

            // Cine
            modelBuilder.ApplyConfiguration(new CineConfig());

            // SalaDeCine
            modelBuilder.ApplyConfiguration(new SalaDeCineConfig());

            // Pelicula
            modelBuilder.ApplyConfiguration(new PeliculaConfig());

            // CineOferta
            modelBuilder.ApplyConfiguration(new CineOfertaConfig());

            // PeliculaActor
            modelBuilder.ApplyConfiguration(new PeliculaActorConfig());
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
