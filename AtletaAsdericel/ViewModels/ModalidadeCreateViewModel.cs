using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.ViewModels
{
    public class ModalidadeCreateViewModel
    {
        public bool IsModalidade { get; set; }
        public string Nome { get; set; }
        public ESexo Sexo { get; set; }
        public ECategoria Categoria { get; set; }
        public int ModalidadePai { get; set; }
        public IEnumerable<Prova> Provas { get; set; }

        internal Modalidade ToEntity()
        {
            return new Modalidade()
            {
                Nome = this.Nome,
                Sexo = this.Sexo,
                Categoria = this.Categoria,
                ModalidadePai = this.ModalidadePai
            };
        }
    }
}
