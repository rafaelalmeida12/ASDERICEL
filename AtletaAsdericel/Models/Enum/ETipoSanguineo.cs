using System.ComponentModel;

namespace AtletaAsdericel.Models.Enum
{
    public enum ETipoSanguineo
    {
        [Description("A Positivo")]
        Apositovo = 1,
        [Description("A Negativo")]
        Anegativo = 2,
        [Description("B Positivo")]
        Bpositovo = 3,
        [Description("B Negativo")]
        Bnegativo = 4,
        [Description("AB Positivo")]
        ABpositovo = 5,
        [Description("Ab Negativo")]
        ABnegativo = 6,
        [Description("O Positivo")]
        Opositovo = 7,
        [Description("O Negativo")]
        Onegativo = 8

    }
}
