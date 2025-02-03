using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models
{
    //[Table("contact")]
    public class Contact
    {
        public Guid Id { get; init; }
        public TypeContact TypeContact { get; set; }
        public string ContactName { get; set; }
        [ForeignKey("Pessoa")]
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public bool Favorite { get; set; }
    }
}
