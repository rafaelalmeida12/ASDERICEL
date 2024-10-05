using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.ViewModels
{
    public class ProvasCreateViewModel
    {
        public string Nome { get; set; }
        public ETipoProva TipoProva { get; set; }
        public int ModalidadeId { get; set; }

        internal Prova ToEntity()
        {
            return new Prova()
            {
                Nome = Nome,
                TipoProva = TipoProva,
                ModalidadeId= ModalidadeId
            };
        }
    }
}
