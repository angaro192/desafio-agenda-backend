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

        public List<Pessoa> GetPessoaList()
        {
            var result = _pessoaRepository.FindAll();
            return result;
        }
    }
}
