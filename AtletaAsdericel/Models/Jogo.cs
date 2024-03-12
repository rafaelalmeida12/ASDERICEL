namespace AtletaAsdericel.Models
{
    public class Jogo
    {
        public int Numero { get; set; }
        public string Local { get; set; }
        public Equipe Equipe1 { get; set; }
        public Equipe Equipe2 { get; set; }
    }
}
