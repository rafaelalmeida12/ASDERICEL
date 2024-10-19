using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AtletaAsdericel.Models.Enum
{
    public enum ETipoSanguineo
    {
        [Display(Name = "A +")]
        Apositovo = 1,
        [Display(Name = "A -")]
        Anegativo = 2,
        [Display(Name = "B +")]
        Bpositovo = 3,
        [Display(Name = "B -")]
        Bnegativo = 4,
        [Display(Name = "AB +")]
        ABpositovo = 5,
        [Display(Name = "Ab -")]
        ABnegativo = 6,
        [Display(Name = "O +")]
        Opositovo = 7,
        [Display(Name = "O -")]
        Onegativo = 8

    }
}
