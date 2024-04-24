using AtletaAsdericel.Data;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    [Route("[controller]")]
    public class AtletaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AtletaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var atletas = await _context.Associado.Include(e => e.Endereco).ToListAsync();
            return View(atletas);
        }
        public ActionResult Create()
        {
            var modalidades = _context.Modalidades.ToList();
            var model = new AtletaCreateViewModel(modalidades);

            return View(model);
        }
    }
}
