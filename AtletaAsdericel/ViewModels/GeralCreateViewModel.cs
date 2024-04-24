using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.ViewModels
{
    public class GeralCreateViewModel
    {
        public string Nome { get; set; }
        public string? NomeSocial { get; set; }
        public string? Apelido { get; set; }
        public DateTime DataNascimento { get; set; } 
        public ESexo Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string? OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string? TipoDocumento { get; set; }
        public string? Passaporte { get; set; }
        public string? NumeroSus { get; set; }
        public ETipoSanguineo TipoSanguineo { get; set; }
        //relacionamentos
        //VALIDAR
        public Endereco Endereco { get; set; }
        //demais dados

        public Associado ToEntity()
        {
            var atleta = new Associado()
            {
                Nome = this.Nome,
                NomeSocial = this.NomeSocial,
                Apelido = this.Apelido,
                DataNascimento = DateTime.Now,
                Sexo = this.Sexo,
                CPF = this.CPF,
                Passaporte = this.Passaporte,
                NumeroSUS = this.NumeroSus,
                TipoSanguineo = this.TipoSanguineo,
                RG = this.RG,
                OrgaoEmissor = this.OrgaoEmissor,
                DataExpedicao = DateTime.Now,
                TipoDocumento = this.TipoDocumento,
                Endereco = this.Endereco
            };
            return atleta;
        }
    }
}
