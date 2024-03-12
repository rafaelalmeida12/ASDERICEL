using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.Models
{
    public class Associado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public string CPF { get; set; }
        public string Passaporte { get; set; }
        public string? NumeroSUS { get; set; }
        public ETipoSanguineo TipoSanguineo { get; set; }
        public string RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string TipoDocumento { get; set; }

        //relacionamentos
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public int ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }
    }
}

