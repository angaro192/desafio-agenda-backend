using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; init; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        [ForeignKey("Pessoa")]
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
