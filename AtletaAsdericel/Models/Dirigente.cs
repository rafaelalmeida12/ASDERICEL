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
        public string? Apelido { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string? OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; } = DateTime.Now;
        public string? TipoDocumento { get; set; }
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
        //relacionamentos
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public string CREF { get; set; }
        public int ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }
    }
}
