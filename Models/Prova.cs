using AtletaAsdericel.Models;

namespace AtletaAsdericel.Models
{
    public class Prova
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }
    }
}
