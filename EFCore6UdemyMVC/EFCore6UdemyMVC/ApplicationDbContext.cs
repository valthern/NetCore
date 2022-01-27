using EFCore6UdemyMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore6UdemyMVC
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
