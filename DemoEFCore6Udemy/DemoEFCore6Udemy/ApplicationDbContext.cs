using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFCore6Udemy
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NECRO\\DEVELOPMENT;Database=DemoEFCore6Udemy;User ID=sa;Password=Almanzor");
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
