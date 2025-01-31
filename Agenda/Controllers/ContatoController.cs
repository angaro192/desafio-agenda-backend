using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        public ContatoController()
        {
                
        }

        [HttpGet]
        public IActionResult findAll()
        {
            return Ok();
        }
    }
}
