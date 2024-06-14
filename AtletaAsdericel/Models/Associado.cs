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
        //public string Discriminator { get; protected set; }

    }
}

