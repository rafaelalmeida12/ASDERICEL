using AtletaAsdericel.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtletaAsdericel.Models
{
    public class Dirigente
    {
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
        public string OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; } = DateTime.Now;
        public string? Profissao { get; set; }
        public string? Passaporte { get; set; }
        public string? NumeroSUS { get; set; }
        public string? CREF { get; set; }
        public string Celular { get; set; }
        public string? Instagram { get; set; }

        public string Peso { get; set; }
        public string Altura { get; set; }
        public ECamisa Camisa { get; set; }
        public ECalca Calca { get; set; }


        public ETipoSanguineo TipoSanguineo { get; set; }
        public EStadoCivil EstadoCivil { get; set; }
        public EEnsino Ensino { get; set; }

        //relacionamentos
        public int FederacaoId { get; set; }
        public List<Federacao> Federacoes { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public int ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }

        public void Atualiza(Dirigente dirigente)
        {
            this.Pai = dirigente.Pai;
            this.Mae = dirigente.Mae;
            this.Nome = dirigente.Nome;
            this.NomeSocial = dirigente.NomeSocial;
            this.NomeConhecido = dirigente.NomeConhecido;
            this.DataNascimento = dirigente.DataNascimento;
            this.Sexo = dirigente.Sexo;
            this.CPF = dirigente.CPF;
            this.CIN_RG = dirigente.CIN_RG;
            this.OrgaoEmissor = dirigente.OrgaoEmissor;
            this.DataExpedicao = dirigente.DataExpedicao;
            this.Passaporte = dirigente.Passaporte;
            this.NumeroSUS = dirigente.NumeroSUS;
            this.TipoSanguineo = dirigente.TipoSanguineo;
            this.EstadoCivil = dirigente.EstadoCivil;
            this.Profissao = dirigente.Profissao;
            this.Ensino = dirigente.Ensino;
            this.Peso = dirigente.Peso;
            this.Altura = dirigente.Altura;
            this.Camisa = dirigente.Camisa;
            this.Calca = dirigente.Calca;
            this.CREF = dirigente.CREF;
            this.Endereco = dirigente.Endereco;
        }
    }
}
