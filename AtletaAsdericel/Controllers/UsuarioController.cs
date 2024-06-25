using AtletaAsdericel.Migrations;
using AtletaAsdericel.Models;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AtletaAsdericel.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        public UsuarioController(SignInManager<Usuario> signInManager, UserManager<Usuario> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult Index()
        {
            var usuarios = _userManager.Users.ToList();
            return View(usuarios);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(login.Nome!, login.Senha!, login.Lembrar, false);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");
                else if (result.IsLockedOut)
                {
                    ModelState.AddModelError(string.Empty, "Conta bloqueada.");
                    return View(login);
                }
                else if (result.IsNotAllowed)
                {
                    ModelState.AddModelError(string.Empty, "Login não permitido.");
                    return View(login);
                }
                else if (result.RequiresTwoFactor)
                {
                    return RedirectToAction("SendCode", new { RememberMe = login.Lembrar });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Tentativa de login inválida.");
                }
                ModelState.AddModelError("", "Inválido login");
                return View(login);
            }
            else { 
            
            }
            return View();
        }
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registrar(CriarUsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new()
                {
                    UserName = model.Nome,
                    NormalizedUserName = model.Nome,
                    Email = model.Email,
                    Nome = model.Nome,
                    Senha = model.Senha,
                    Perfil = "ADM"
                };

                var user = await _userManager.CreateAsync(usuario, model.Senha!);
                if (user.Succeeded)
                {
                    await _userManager.AddToRoleAsync(usuario, model.Perfil);
                    //await _signInManager.SignInAsync(usuario, false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in user.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
