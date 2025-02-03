using Agenda.BLL;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ContactService _contactService;

        public ContactController(ContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contact contact)
        {
            var result = _contactService.Create(contact);
            if (result) return Ok("Contato criado com sucesso");

            return BadRequest("Erro ao criar contato");
        }


        [HttpGet]
        public IActionResult FindAll()
        {
            var conctactList = _contactService.GetContatoList();
            return Ok(conctactList);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindById([FromRoute] string id)
        {
            var contact = _contactService.GetContatoById(new Guid(id));
            if (contact == null) return NotFound("Contato não encontrado");
            return Ok(contact);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Contact contact)
        {
            var result = _contactService.Update(contact);
            if (result) return Ok("Contato atualizado com sucesso");
            return BadRequest("Erro ao atualizar contato");
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] string id)
        {
            var contact = _contactService.Delete(new Guid(id));
            if (contact) return Ok("Contato deletado com sucesso");
            return BadRequest("Erro ao deletar contato");
        }
    }
}
