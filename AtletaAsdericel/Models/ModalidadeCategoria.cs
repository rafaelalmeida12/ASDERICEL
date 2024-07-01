namespace AtletaAsdericel.Models
{
    public class ModalidadeCategoria
    {
        public int ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
