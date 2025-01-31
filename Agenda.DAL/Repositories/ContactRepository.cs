using Agenda.Models;

namespace Agenda.DAL.Repositories
{
    public class ContactRepository
    {
        public ContactRepository() { }
        public bool create(Contato contato)
        {
            return false;
        }

        public List<Contato> findAll()
        {
            return new List<Contato>();
        }
    }
}
