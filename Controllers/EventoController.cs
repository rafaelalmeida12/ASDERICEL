using AtletaAsdericel.Data;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    public class EventoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EventoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var eventos = await _context.Evento.ToListAsync();
            return View(eventos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EventoCreateViewModel model)
        {

            return View();
        }
    }
}
