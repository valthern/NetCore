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

            modelBuilder.Entity<Genero>().HasKey(prop => prop.Identificador);
            modelBuilder.Entity<Genero>().Property(prop => prop.Nombre)
                //.HasColumnName("NombreGenero")
                .HasMaxLength(150)
                .IsRequired();
            //modelBuilder.Entity<Genero>().ToTable(name: "TablaGeneros", schema: "Peliculas");

            modelBuilder.Entity<Actor>().Property(prop => prop.Nombre)
                .HasMaxLength(150)
                .IsRequired();
        }
        
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; } 
    }
}
