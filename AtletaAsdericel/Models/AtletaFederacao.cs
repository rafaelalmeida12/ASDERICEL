namespace AtletaAsdericel.Models
{
	public class AtletaFederacao
	{
		public int AtletaId { get; set; }
		public Atleta Atleta { get; set; }

		public int FederacaoId { get; set; }
		public Federacao Federacao { get; set; }
	}

}
