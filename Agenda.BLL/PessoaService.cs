using Agenda.DAL.DTOs;
using Agenda.DAL.Repositories;
using Agenda.Models;

namespace Agenda.BLL
{
    public class PessoaService
    {
        private readonly PessoaRepository _pessoaRepository;
        public PessoaService(PessoaRepository repository)
        {
            _pessoaRepository = repository;
        }
        public bool Create(Pessoa pessoa)
        {
            var result = _pessoaRepository.Create(pessoa);
            return result;
        }

        public List<PessoaDto> GetPessoaList()
        {
            var pessoas = _pessoaRepository.FindAll();
            var pessoaDtos = pessoas.Select(p => new PessoaDto
            {
                Id = p.Id,
                Name = p.Name,
                Photo = p.Photo,
                TypePicture = p.TypePicture,
                Contact = p.Contact != null ? new ContactDto
                {
                    Id = p.Contact.Id,
                    TypeContact = p.Contact.TypeContact,
                    Contact = p.Contact.ContactName,
                    Favorite = p.Contact.Favorite
                } : null
            }).ToList();

            return pessoaDtos;
        }
    }
}
