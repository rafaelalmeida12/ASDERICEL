using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.Models
{
    public class Prova
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ModalidadeId { get; set; }
        public ETipoProva TipoProva { get; set; }
        public Modalidade Modalidade { get; set; }
    }
}
