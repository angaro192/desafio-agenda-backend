namespace Agenda.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Photo { get; set; }
        public TypePicture TypePicture { get; set; }
    }
}
