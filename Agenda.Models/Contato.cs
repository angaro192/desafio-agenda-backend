namespace Agenda.Models
{
    public class Contato
    {
        public Guid Id { get; set; }
        public TypeContact TypeContact { get; set; }
        public string ContactName { get; set; }
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Boolean Favorite { get; set; }
    }
}
