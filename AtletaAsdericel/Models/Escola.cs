namespace AtletaAsdericel.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? INEP { get; set; }
        public string? Telefone { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
    }
}