using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.ViewModels
{
    public class AtletaCreateViewModel
    {
        public AtletaCreateViewModel()
        {

        }
        public AtletaCreateViewModel(List<Modalidade> modalidades, List<Federacao> federacoes)
        {
            Modalidades = modalidades;
            Federacoes = federacoes;
        }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public string NomeSocial { get; set; }
        public string NomeConhecido { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public string CPF { get; set; }
        public string CIN_RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string Passaporte { get; set; }
        public string NumeroSus { get; set; }
        public string Celular { get; set; }
        public string? Instagram { get; set; }

        public string Peso { get; set; }
        public string Altura { get; set; }
        public ETipoSanguineo TipoSanguineo { get; set; }
        public EStadoCivil EstadoCivil { get; set; }
        public ECamisa Camisa { get; set; }
        public ECalca Calca { get; set; }
        public EEnsino Ensino { get; set; }
		public ETipoCadastro TipoCadastro { get; set; }
		public string Numero_Registro { get; set; }
        //relacionamentos
        public int FederacaoId { get; set; }
        public List<Federacao> Federacoes { get; set; }
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

        public Atleta ToEntity()
        {
            var atleta = new Atleta()
            {
                Nome = this.Nome,
                NomeSocial = this.NomeSocial,
                NomeConhecido = this.NomeConhecido,
                DataNascimento = this.DataNascimento,
                Mae = this.Mae,
                Pai = this.Pai,
                EstadoCivil = this.EstadoCivil,
                Sexo = this.Sexo,
                Profissao = this.Profissao,
                CPF = this.CPF,
                CIN_RG = this.CIN_RG,
                OrgaoEmissor = this.OrgaoEmissor,
                DataExpedicao = this.DataExpedicao,
                Passaporte = this.Passaporte,
                NumeroSUS = this.NumeroSus,
                TipoSanguineo = this.TipoSanguineo,
                Ensino = this.Ensino,
                Peso = this.Peso,
                Altura = this.Altura,
                Camisa = this.Camisa,
                Calca = this.Calca,
                ModalidadeId = this.ModalidadeId,
                Endereco = this.Endereco,
                Escola = this.Escola
            };

            return atleta;
        }
    }
}
