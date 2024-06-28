using AtletaAsdericel.Data;
using AtletaAsdericel.Models;
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
            var atletas = await _context.Atletas
                                .Include(e => e.Endereco)
                                .Include(e => e.Modalidade)
                                .ToListAsync();
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
            var atleta = await _context.Atletas.Include(a=>a.Escola).Include(a=>a.Endereco).FirstOrDefaultAsync(e => e.Id == id);
            return View(atleta);
        }

        [HttpPost("Editar")]
        public async Task<ActionResult> Edit(Atleta atleta)
        {
            var atletaBanco = await _context.Atletas.Include(a => a.Escola).Include(a => a.Endereco).FirstOrDefaultAsync(e => e.Id == atleta.Id);
            atletaBanco.Atualiza(atleta);

            _context.Update(atletaBanco);
            await _context.SaveChangesAsync();
            return View();
        }

        [HttpGet("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            var atleta = await _context.Atletas.FirstOrDefaultAsync(e => e.Id == id);
            return View(atleta);
        }

        [HttpPost("Delete")]
        public async Task<ActionResult> Delete(Atleta atleta)
        {
            var atletaBanco = await _context.Atletas.FirstOrDefaultAsync(e => e.Id == atleta.Id);
             _context.Remove(atletaBanco);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
