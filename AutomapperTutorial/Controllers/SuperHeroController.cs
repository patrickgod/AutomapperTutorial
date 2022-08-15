using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero {
                Id = 1,
                Name ="Spider Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City",
                DateAdded = new DateTime(2001, 08, 10),
                DateModified = null
            },
            new SuperHero {
                Id = 2,
                Name ="Iron Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "Malibu",
                DateAdded = new DateTime(1970, 05, 29),
                DateModified = null
            }
        };

        [HttpGet]
        public ActionResult<List<SuperHero>> GetHeroes()
        {
            return heroes;
        }
    }
}
