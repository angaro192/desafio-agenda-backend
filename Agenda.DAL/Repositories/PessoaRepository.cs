using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.DAL.Repositories
{
    public class PessoaRepository
    {
        private readonly AppDbContext _context;
        public PessoaRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool Create(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            return _context.SaveChanges() > 0;
        }

        public List<Pessoa> FindAll()
        {
            List<Pessoa> pessoas = _context.Pessoas.Include(p => p.Contact).ToList();
            return pessoas;
        }

        public Pessoa? FindById(Guid id)
        {
            //Pessoa? pessoa = _context.Pessoas.FirstOrDefault(x => x.Id == id);
            Pessoa? pessoa = _context.Pessoas.Include(p => p.Contact).FirstOrDefault(x => x.Id == id);
            return pessoa;
        }
    }
}
