using System.ComponentModel.DataAnnotations;

namespace AtletaAsdericel.Models
{
    public class Federacao
    {
        [Key]
        public int Id { get; set; }
        public string Sigla { get; set; }
    }
}
