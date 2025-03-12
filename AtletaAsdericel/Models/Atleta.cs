using AtletaAsdericel.Models.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtletaAsdericel.Models
{
	public class Atleta
	{
		public Atleta()
		{

		}

		public Atleta(SelectList modalidades, SelectList federacoes)
		{
			this.modalidades = modalidades;
			this.federacoes = federacoes;
		}

		[Key]
		public int Id { get; set; }
		public string? Pai { get; set; }
		public string Mae { get; set; }
		public string Nome { get; set; }
		public string? NomeSocial { get; set; }
		public string? NomeConhecido { get; set; }
		public DateTime DataNascimento { get; set; }
		public ESexo Sexo { get; set; }
		public string CPF { get; set; }
		public string CIN_RG { get; set; }
		public string? OrgaoEmissor { get; set; }
		public DateTime DataExpedicao { get; set; } 
		public string? Passaporte { get; set; }
		public string? NumeroSUS { get; set; }
		public ETipoSanguineo TipoSanguineo { get; set; }
		public EStadoCivil EstadoCivil { get; set; }
		public string? Profissao { get; set; }
		public EEnsino Ensino { get; set; }
		public string Peso { get; set; }
		public string Altura { get; set; }
		public ECamisa Camisa { get; set; }
		public ECalca Calca { get; set; }
		public ETipoCadastro TipoCadastro { get; set; }


		//relacionamentos
		public int EnderecoId { get; set; }
		public Endereco Endereco { get; set; }
		public int EscolaId { get; set; }
		public Escola Escola { get; set; }

		public List<AtletaModalidade> AtletaModalidades { get; set; } = new();
		public List<AtletaFederacao> AtletaFederacoes { get; set; } = new();
		[NotMapped]
		public SelectList federacoes { get; set; }
		[NotMapped]
		public SelectList modalidades { get; set; } 
		//public IEnumerable<Modalidade> Modalidades { get; set; }

		public void Atualiza(Atleta atleta)
		{
			this.Pai = atleta.Pai;
			this.Mae = atleta.Mae;
			this.Nome = atleta.Nome;
			this.NomeSocial = atleta.NomeSocial;
			this.NomeConhecido = atleta.NomeConhecido;
			this.DataNascimento = atleta.DataNascimento;
			this.Sexo = atleta.Sexo;
			this.CPF = atleta.CPF;
			this.CIN_RG = atleta.CIN_RG;
			this.OrgaoEmissor = atleta.OrgaoEmissor;
			this.DataExpedicao = atleta.DataExpedicao;
			this.Passaporte = atleta.Passaporte;
			this.NumeroSUS = atleta.NumeroSUS;
			this.TipoSanguineo = atleta.TipoSanguineo;
			this.EstadoCivil = atleta.EstadoCivil;
			this.Profissao = atleta.Profissao;
			this.Ensino = atleta.Ensino;
			this.Peso = atleta.Peso;
			this.Altura = atleta.Altura;
			this.Camisa = atleta.Camisa;
			this.Calca = atleta.Calca;
			this.Endereco = atleta.Endereco;
			this.Escola = atleta.Escola;
		}
	}
}
