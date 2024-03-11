namespace AtletaAsdericel.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Associado> Associados { get; set; }
        public Resultado Resultado { get; set; }
    }
}
