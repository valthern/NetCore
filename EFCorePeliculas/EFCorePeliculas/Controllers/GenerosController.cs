using EFCorePeliculas.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController:ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GenerosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Genero>> Get()
        {
            //return await context.Generos.AsNoTracking().ToListAsync();
            return await context.Generos.ToListAsync();
        }

        [HttpGet("primer")]
        public async Task<Genero> Primer()
        {
            return await context.Generos.FirstAsync(g => g.Nombre.StartsWith("C"));
        }
    }
}
