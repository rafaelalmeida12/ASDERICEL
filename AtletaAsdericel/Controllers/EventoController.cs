using AtletaAsdericel.Data;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    [Route("[controller]")]

    public class EventoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EventoController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var eventos = await _context.Evento.ToListAsync();
            return View(eventos);
        }
        [HttpGet("Criar")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Criar")]
        public IActionResult Create(EventoCreateViewModel viewModel)
        {
            _context.Add(viewModel.ToEntity());
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
