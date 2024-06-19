using Microsoft.AspNetCore.Identity;

namespace AtletaAsdericel.Models
{
    public class Usuario:IdentityUser
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
    }
}
