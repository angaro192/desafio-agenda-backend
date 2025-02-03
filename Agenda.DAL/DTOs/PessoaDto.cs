using Agenda.Models;

namespace Agenda.DAL.DTOs
{
    public class PessoaDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public TypePicture TypePicture { get; set; }
        public ContactDto Contact { get; set; }
    }
}
