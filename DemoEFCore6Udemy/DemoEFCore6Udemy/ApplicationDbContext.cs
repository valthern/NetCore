using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFCore6Udemy
{
    public class ApplicationDbContext:DbContext
    {
        public string User { get; set; } = "sa";
        public string Password { get; set; } = "A1m4n$0r";
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=SISTEMAS3\\DEVELOPMENT;Database=DemoEFCore6Udemy;User ID={User};Password={Password}");
        }
    }
}
