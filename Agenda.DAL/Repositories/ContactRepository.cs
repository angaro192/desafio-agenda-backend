using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.DAL.Repositories
{
    public class ContactRepository
    {
        private readonly AppDbContext _context;
        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Create(Contact contato)
        {
            _context.Contacts.Add(contato);
            return _context.SaveChanges() > 0;
        }

        public List<Contact> FindAll()
        {
            List<Contact> contacts = _context.Contacts.ToList();
            return contacts;
        }

        public Contact? FindById(Guid id)
        {
            Contact? contact = _context.Contacts.FirstOrDefault(x => x.Id == id);
            return contact;
        }

        public bool Update(Contact contato)
        {
            _context.Contacts.Update(contato);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(Contact contato)
        {
            _context.Contacts.Remove(contato);
            return _context.SaveChanges() > 0;
        }
    }
}
