using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class Pessoa
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public TypePicture TypePicture { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }
}
