namespace AtletaAsdericel.Models
{
	public class AtletaModalidade
	{
		public int AtletaId { get; set; }
		public Atleta Atleta { get; set; }

		public int ModalidadeId { get; set; }
		public Modalidade Modalidade { get; set; }
	}

}
