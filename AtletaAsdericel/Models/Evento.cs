namespace AtletaAsdericel.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Edicao{ get; set; }
        public string   Categoria { get; set; }
        public string   Municipio { get; set; }
        public string   Estado { get; set; }
        public string   Pais { get; set; }
        public string Promocao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public IEnumerable<Equipe> Equipes { get; set; }


    }
}
