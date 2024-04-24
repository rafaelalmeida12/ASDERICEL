namespace AtletaAsdericel.Models
{
    public class Atleta:Associado
    {
        public int EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
