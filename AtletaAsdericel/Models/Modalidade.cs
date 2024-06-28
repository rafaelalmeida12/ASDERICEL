
namespace AtletaAsdericel.Models
{
    public class Modalidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Sexo> Sexos { get; set; }
        public List<CategoriaModalidade> CategoriaModalidades { get; set; } = new();
        public int ModalidadePai { get; set; }
        //public IEnumerable<Prova> Provas { get; set; }

        internal void Atualiza(Modalidade modalidade)
        {
            Nome = modalidade.Nome;
            Sexos = modalidade.Sexos;
            CategoriaModalidades = modalidade.CategoriaModalidades;
            ModalidadePai = modalidade.ModalidadePai;
        }
    }
}
