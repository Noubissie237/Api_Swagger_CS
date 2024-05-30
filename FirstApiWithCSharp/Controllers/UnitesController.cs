using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiWithCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>()
            {
                "INF121:ALGORITHME",
                "INF232:PROGRAMMATION ORIENTEE OBJET"
            };
        }
    }
}
