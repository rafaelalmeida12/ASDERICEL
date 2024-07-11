using System.ComponentModel.DataAnnotations;

namespace AtletaAsdericel.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Lembrar { get; set; }
    }
}
