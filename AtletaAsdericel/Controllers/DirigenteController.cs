using AtletaAsdericel.Data;
using AtletaAsdericel.Migrations;
using AtletaAsdericel.Models;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    [Route("[controller]")]

    public class DirigenteController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DirigenteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var atletas = await _context.Dirigente.Include(e => e.Endereco).ToListAsync();
            return View(atletas);
        }

        [HttpGet("Criar")]
        public ActionResult Create()
        {
            var modalidades = _context.Modalidades.ToList();
            var model = new DirigenteCreateViewModel(modalidades);
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost("Criar")]
        public ActionResult Create(DirigenteCreateViewModel viewModel)
        {
            try
            {
                _context.Add(viewModel.ToEntity());
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(viewModel);
            }
        }
        [HttpGet("Editar")]
        public ActionResult Edit(int id)
        {
            var dirigente = _context.Dirigente.FirstOrDefaultAsync(e => e.Id == id);
            return View(dirigente);
        }

        [HttpPost("Editar")]
        public async Task<ActionResult> Edit(Dirigente dirigente)
        {
            var dirigenteBanco = await _context.Dirigente.FirstOrDefaultAsync(e => e.Id == dirigente.id);
            dirigenteBanco.Atualiza(dirigente);

            _context.Add(dirigenteBanco);
            await _context.SaveChangesAsync();
            return View();
        }

    }
}
