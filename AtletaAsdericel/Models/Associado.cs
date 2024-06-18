using AtletaAsdericel.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace AtletaAsdericel.Models
{
    public class Associado
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? NomeSocial { get; set; }
        public string? Apelido { get; set; }
        public string Mae { get; set; }
        public string? Pai { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string? OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string? Passaporte { get; set; }
        public string? NumeroSUS { get; set; }
        public ETipoSanguineo TipoSanguineo { get; set; }
        public EStadoCivil EstadoCivil { get; set; }
        public string? Profissao { get; set; }
        public EEnsino Ensino { get; set; }
        //relacionamentos
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Associado associado &&
                   Nome == associado.Nome &&
                   NomeSocial == associado.NomeSocial &&
                   Apelido == associado.Apelido &&
                   Mae == associado.Mae &&
                   Pai == associado.Pai &&
                   DataNascimento == associado.DataNascimento &&
                   Sexo == associado.Sexo &&
                   CPF == associado.CPF &&
                   RG == associado.RG &&
                   OrgaoEmissor == associado.OrgaoEmissor &&
                   DataExpedicao == associado.DataExpedicao &&
                   Passaporte == associado.Passaporte &&
                   NumeroSUS == associado.NumeroSUS &&
                   TipoSanguineo == associado.TipoSanguineo &&
                   EstadoCivil == associado.EstadoCivil &&
                   Profissao == associado.Profissao &&
                   Ensino == associado.Ensino &&
                   EnderecoId == associado.EnderecoId &&
                   EqualityComparer<Endereco>.Default.Equals(Endereco, associado.Endereco);
        }

        internal void Atualiza(Associado associado)
        {
            this.Nome = associado.Nome;
            this.NomeSocial = associado.NomeSocial;
            this.Apelido = associado.Apelido;
            this.Mae = associado.Mae;
            this.Pai = associado.Pai;
            this.DataNascimento = associado.DataNascimento.ToUniversalTime();
            this.Sexo = associado.Sexo;
            this.CPF = associado.CPF;
            this.RG = associado.RG;
            this.OrgaoEmissor = associado.OrgaoEmissor;
            this.DataExpedicao = associado.DataExpedicao.ToUniversalTime();
            this.Passaporte = associado.Passaporte;
            this.NumeroSUS = associado.NumeroSUS;
            this.TipoSanguineo = associado.TipoSanguineo;
            this.EstadoCivil = associado.EstadoCivil;
            this.Profissao = associado.Profissao;
            this.Ensino = associado.Ensino;
            this.EnderecoId = associado.EnderecoId;
            this.Endereco = associado.Endereco;
        }
        //public string Discriminator { get; protected set; }

    }
}

