using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.ViewModels
{
    public class GeralCreateViewModel
    {
        public string Nome { get; set; }
        public string? NomeSocial { get; set; }
        public string? NomeConhecido { get; set; }
        public string Mae { get; set; }
        public string? Pai { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string? OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string? TipoDocumento { get; set; }
        public string? Passaporte { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string? Instagram { get; set; }
        public string? Observacao { get; set; }
        public ETipoCadastro TipoCadastro { get; set; }
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
                NomeConhecido = this.NomeConhecido,
                Mae = this.Mae,
                Pai = this.Pai,
                DataNascimento = this.DataNascimento.ToUniversalTime(),
                Sexo = this.Sexo,
                CPF = this.CPF,
                Passaporte = this.Passaporte??string.Empty,
                RG = this.RG,
                Celular=this.Celular,
                Email=this.Email,
                Instagram=this.Instagram,
                OrgaoEmissor = this.OrgaoEmissor,
                DataExpedicao = this.DataExpedicao.ToUniversalTime(),
                Endereco = this.Endereco
            };
            return atleta;
        }
    }
}
