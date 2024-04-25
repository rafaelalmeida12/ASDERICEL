﻿using AtletaAsdericel.Models;
using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.ViewModels
{
    public class DirigenteCreateViewModel
    {
        public DirigenteCreateViewModel()
        {
            
        }
        public DirigenteCreateViewModel(List<Modalidade> modalidades)
        {
            Modalidades = modalidades;
        }

        public ETipo Tipo { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string Profissao { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
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
        public ECamisa Camisa { get; set; }
        public ECalca Calca { get; set; }

        public string CREF { get; set; }
        public ETipoSanguineo TipoSanguineo { get; set; }
        public EStadoCivil EstadoCivil { get; set; }

        public EEnsino Ensino { get; set; }
        //relacionamentos
        public Endereco Endereco { get; set; }
        public int ModalidadeId { get; set; }
        public List<Modalidade> Modalidades { get; set; }
        //demais dados

        public Dirigente ToEntity()
        {
            var atleta = new Dirigente()
            {
                Nome = this.Nome,
                NomeSocial = this.NomeSocial,
                Apelido = this.Apelido,
                DataNascimento = this.DataNascimento,
                Mae=this.Mae,
                Pai=this.Pai,
                EstadoCivil=this.EstadoCivil,
                Sexo = this.Sexo,
                Profissao=this.Profissao,
                CPF = this.CPF,
                RG = this.RG,
                OrgaoEmissor = this.OrgaoEmissor,
                DataExpedicao = this.DataExpedicao,
                CREF=this.CREF,
                Passaporte = this.Passaporte,
                TipoDocumento = this.TipoDocumento,
                NumeroSUS = this.NumeroSus,
                TipoSanguineo = this.TipoSanguineo,
                Ensino=this.Ensino,
                Peso=this.Peso,
                Altura=this.Altura,
                Camisa=this.Camisa,
                Calca=this.Calca,
                ModalidadeId=this.ModalidadeId,
                Endereco = this.Endereco,
            };

            return atleta;
        }
    }
}
