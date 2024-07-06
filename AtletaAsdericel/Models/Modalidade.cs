
using AtletaAsdericel.ViewModels;

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

        internal void Atualiza(ModalidadeEditViewModel modalidade)
        {
            Nome = modalidade.Nome;
            //ModalidadeSexos = modalidade.Sexos;
            //ModalidadeCategorias = modalidade.CategoriaModalidades;
            //ModalidadePai = modalidade.ModalidadePai;
        }
    }
}
