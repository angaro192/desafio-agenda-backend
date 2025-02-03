using Agenda.DAL.Repositories;
using Agenda.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Agenda.BLL
{
    public class ContactService
    {
        private readonly ContactRepository _contactRepository;
        private readonly PessoaRepository _pessoaRepository;
        private readonly IValidator<Contact> _contactValidator;

        public ContactService(ContactRepository repository, PessoaRepository pessoaRepository)
        {
            _contactRepository = repository;
            _pessoaRepository = pessoaRepository;
        }

        public bool Create(Contact contact)
        {
            var validation = _contactValidator.Validate(contact);
            if (!validation.IsValid)
            {
                return false;
            }
            if (contact.Pessoa == null || contact.Pessoa.Id == Guid.Empty)
            {
                var resultPessoa = _pessoaRepository.Create(contact.Pessoa);
                if (!resultPessoa)
                {
                    return false;
                }
            }
            var pessoaExist = _pessoaRepository.FindById(contact.Pessoa.Id);
            if (pessoaExist == null)
            {
                return false;
            }
            contact.Pessoa = pessoaExist;

            var result = _contactRepository.Create(contact);
            return result;
        }

        public List<Contact> GetContatoList()
        {
            var result = _contactRepository.FindAll();
            return result;
        }

        public Contact? GetContatoById(Guid id)
        {
            var result = _contactRepository.FindById(id);
            return result;
        }

        public bool Update(Contact contato)
        {
            var contact = _contactRepository.FindById(contato.Id);
            if (contact == null) return false;
            contact.ContactName = contato.ContactName;
            contact.TypeContact = contato.TypeContact;
            var result = _contactRepository.Update(contact);
            return result;
        }

        public bool Delete(Guid id)
        {
            var contact = _contactRepository.FindById(id);
            if (contact == null) return false;
            var result = _contactRepository.Delete(contact);
            return result;
        }
    }
}
