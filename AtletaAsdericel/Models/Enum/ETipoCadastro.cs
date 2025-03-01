using System.ComponentModel.DataAnnotations;

namespace AtletaAsdericel.Models.Enum
{
	public enum ETipoCadastro
	{
		[Display(Name = "Sócio Fundador")]
		Socio_Fundador = 1,

		[Display(Name = "Sócio Efetivo")]
		Socio_Efetivo = 2,

		[Display(Name = "Sócio Honorário")]
		Socio_Honorario = 3,

		[Display(Name = "Estagiário")]
		Estagiario = 4
	}
}
