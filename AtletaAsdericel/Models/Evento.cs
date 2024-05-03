namespace AtletaAsdericel.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Edicao { get; set; }
        public string Promotor { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public IEnumerable<Equipe> Equipes { get; set; }


    }
}
