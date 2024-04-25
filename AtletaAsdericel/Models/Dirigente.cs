namespace AtletaAsdericel.Models
{
    public class Dirigente : Associado
    {
        public string CREF { get; set; }
        public int ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }
    }
}
