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
                if (!ModelState.IsValid)
                {
                    return View(viewModel);
                }
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
        public async Task<ActionResult> Edit(int id)
        {
            var dirigente = await _context.Dirigente.Include(a => a.Endereco).FirstOrDefaultAsync(e => e.Id == id);
            return View(dirigente);
        }

        [HttpPost("Editar")]
        public async Task<ActionResult> Edit(Dirigente dirigente)
        {
            var dirigenteBanco = await _context.Dirigente.Include(a => a.Endereco).FirstOrDefaultAsync(e => e.Id == dirigente.Id);
            dirigenteBanco.Atualiza(dirigente);

            _context.Update(dirigenteBanco);
            await _context.SaveChangesAsync();
            return View();
        }

    }
}
