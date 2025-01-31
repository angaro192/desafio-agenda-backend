using Agenda.Models;
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

        [HttpPost]
        public IActionResult create()
        {
            return Ok();
        }


        [HttpGet]
        public List<Contato> findAll() {
            return new List<Contato>();
        }
    }
}
