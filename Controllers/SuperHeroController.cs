using HeroApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        // ActionResult es un tipo de dato que nos permite devolver un resultado
        // List<SuperHero> es el tipo de dato que vamos a devolver de la función, y también lo podremos ver en el Swagger
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Scarlet Witch",
                    FirstName = "Wanda",
                    LastName = "Maximoff",
                    Place = "Wundagore Mountain"
                }
            };
            // cuando ponemos un return Ok() estamos devolviendo un 200
            return Ok(heroes);
        }
    }
}
