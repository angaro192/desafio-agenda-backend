using Agenda.BLL;
using Agenda.DAL.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaService _pessoaService;

        public PessoaController(PessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public ActionResult<List<PessoaDto>> FindAll()
        {
            var pessoaList = _pessoaService.GetPessoaList();
            return Ok(pessoaList);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Models.Pessoa pessoa)
        {
            var result = _pessoaService.Create(pessoa);
            if (result) return Ok("Pessoa criada com sucesso");
            return BadRequest("Erro ao criar pessoa");
        }
    }
}
