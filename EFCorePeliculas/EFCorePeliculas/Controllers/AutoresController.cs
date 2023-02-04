using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCorePeliculas.DTOs;
using EFCorePeliculas.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas.Controllers
{
    [ApiController]
    [Route("api/actores")]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AutoresController(ApplicationDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // Método que devuelve un tipo anónimo (proyectado)
        //[HttpGet]
        //public async Task<ActionResult> Get()
        //{
        //    var actores = await context.Actores.Select(a => new { Id = a.Id, Nombre = a.Nombre }).ToListAsync();
        //    return Ok(actores);
        //}

        // Método que devuelve un tipo "DTO" (fabricado)
        //[HttpGet]
        //public async Task<IEnumerable<ActorDTO>> Get()
        //{
        //    return await context.Actores.Select(a => new ActorDTO { Id = a.Id, Nombre = a.Nombre }).ToListAsync();
        //}

        // Método que usa AutoMapper
        [HttpGet]
        public async Task<IEnumerable<ActorDTO>> Get()
        {
            return await context.Actores.ProjectTo<ActorDTO>(mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
