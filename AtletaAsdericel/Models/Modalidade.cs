
namespace AtletaAsdericel.Models
{
    public class Modalidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<ModalidadeSexo> ModalidadeSexos { get; set; }
        public ICollection<ModalidadeCategoria> ModalidadeCategorias { get; set; }
        public int ModalidadePai { get; set; }
        //public IEnumerable<Prova> Provas { get; set; }

        internal void Atualiza(Modalidade modalidade)
        {
            Nome = modalidade.Nome;
            //Sexos = modalidade.Sexos;
            //CategoriaModalidades = modalidade.CategoriaModalidades;
            ModalidadePai = modalidade.ModalidadePai;
        }
    }
}
