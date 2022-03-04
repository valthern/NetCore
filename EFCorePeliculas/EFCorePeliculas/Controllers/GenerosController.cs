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
            //return await context.Generos.AsTracking().ToListAsync();
        }

        [HttpGet("primer")]
        public async Task<ActionResult<Genero>> Primer()
        {
            var genero = await context.Generos.FirstOrDefaultAsync(g => g.Nombre.StartsWith("Z"));

            if (genero is null)
            {
                return NotFound();
            }

            return genero;
        }
    }
}
