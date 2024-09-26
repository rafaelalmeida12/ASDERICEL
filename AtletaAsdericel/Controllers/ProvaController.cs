using AtletaAsdericel.Data;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    [Authorize]
    public class ProvaController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        public ProvaController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var modalidades = await _contexto.Provas.ToListAsync();
            return View(modalidades);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProvasCreateViewModel provas)
        {
            //_contexto.Provas.Add(provas.ToEntity());
            await _contexto.SaveChangesAsync();
            return View();
        }
    }
}
