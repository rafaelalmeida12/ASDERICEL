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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var atletas = await _context.Atleta.Include(e => e.Endereco).ToListAsync();
            return View(atletas);
        }

        [HttpGet("Criar")]
        public ActionResult Create()
        {
            var modalidades = _context.Modalidades.ToList();
            var model = new AtletaCreateViewModel(modalidades);

            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost("Criar")]
        public ActionResult Create(AtletaCreateViewModel viewModel)
        {
            try
            {

                //if (!ModelState.IsValid)
                //{
                //    return View(viewModel);
                //}
                _context.Add(viewModel.ToEntity());
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(viewModel);
            }
        }
    }
}
