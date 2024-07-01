namespace AtletaAsdericel.Models
{
    public class ModalidadeSexo
    {
        public int ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }

        public int SexoId { get; set; }
        public Sexo Sexo { get; set; }
    }
}
