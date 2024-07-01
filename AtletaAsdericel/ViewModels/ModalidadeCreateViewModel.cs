using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AtletaAsdericel.ViewModels
{
    public class ModalidadeCreateViewModel
    {
       
        public bool IsModalidade { get; set; }
        public string Nome { get; set; }
        public SelectList Sexos { get; set; }
        public SelectList CategoriaModalidades { get; set; }
        public List<int> SexoIds { get; set; } // Mudança para armazenar os IDs dos sexos selecionados
        public List<int> CategoriaIds { get; set; }
        public int ModalidadePai { get; set; }
        public IEnumerable<Prova> Provas { get; set; }

        public ECategoria eCategoria { get; set; }

        internal Modalidade ToEntity()
        {
            return new Modalidade()
            {
                Nome = this.Nome,
                ModalidadePai = this.ModalidadePai
            };
        }
    }
}
