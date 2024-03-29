﻿using AtletaAsdericel.Models.Enum;

namespace AtletaAsdericel.Models
{
    public class Modalidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ESexo Sexo { get; set; }
        public ECategoria Categoria { get; set; }
        public int ModalidadePai { get; set; }
        public IEnumerable<Prova> Provas { get; set; }
    }
}
