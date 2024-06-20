using Microsoft.AspNetCore.Mvc;

namespace AtletaAsdericel.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
    }
}
