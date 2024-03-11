using AtletaAsdericel.Data;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    public class ModalidadeController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        public ModalidadeController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var modalidades = await _contexto.Modalidades.ToListAsync();
            return View(modalidades);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ModalidadeCreateViewModel modalidade)
        {
            _contexto.Modalidades.Add(modalidade.ToEntity());
            await _contexto.SaveChangesAsync();
            return View();
        }
    }
}
