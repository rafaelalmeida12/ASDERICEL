using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.ViewModels
{
    public class AtletaCreateViewModel
    {
        public ETipo Tipo { get; set; }
        public string Codigo { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public string NomeSocial { get; set; }
        public string Apelido { get; set; }
        public bool IsResponsavel { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string TipoDocumento { get; set; }
        public string Passaporte { get; set; }
        public string NumeroSus { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public ETipoSanguineo TipoSanguineo { get; set; }
        public EStadoCivil EstadoCivil { get; set; }

        public ECamisa Camisa { get; set; }
        public ECalca Calca { get; set; }
        //relacionamentos

        public Endereco Endereco { get; set; }
        public int EscolaId { get; set; }
        public Escola Escola { get; set; }
        public int ResponsavelId { get; set; }
        public List<Responsavel> Responsaveis { get; set; }
        public Responsavel Responsavel { get; set; }
        public int CidadeId { get; set; }
        public List<Cidade> Cidades { get; set; }
        public int EstadoId { get; set; }
        public List<Estado> Estados { get; set; }
        public int ModalidadeId { get; set; }
        public List<Modalidade> Modalidades { get; set; }
        //demais dados

        public Associado ToEntity()
        {
          var atleta= new Associado()
            {
                Nome = this.Nome,
                NomeSocial = this.NomeSocial,
                Apelido = this.Apelido,
                DataNascimento = this.DataNascimento,
                Sexo = this.Sexo,
                CPF = this.CPF,
                Passaporte = this.Passaporte,
                NumeroSUS=this.NumeroSus,
                TipoSanguineo = this.TipoSanguineo,
                RG = this.RG,
                OrgaoEmissor=this.OrgaoEmissor,
                DataExpedicao=this.DataExpedicao,
                TipoDocumento=this.TipoDocumento,
                Responsavel = this.Responsavel,
                Endereco = this.Endereco,
                Pai=this.Pai,
               EstadoCivil=this.EstadoCivil
          };
                   
            return atleta;
        }
    }
}
