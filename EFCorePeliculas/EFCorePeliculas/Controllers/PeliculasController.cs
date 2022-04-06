using EFCorePeliculas.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas.Controllers
{
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PeliculasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pelicula>> Get(int id)
        {
            var pelicula = await context.Peliculas
                .Include(p => p.Generos)
                .Include(p => p.SalasDeCine)
                    .ThenInclude(s => s.Cine)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pelicula is null)
                return NotFound();

            return pelicula;
        }
    }
}
