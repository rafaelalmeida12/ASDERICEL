using AtletaAsdericel.Data;
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
            var atletas = await _context.Dirigentes.Include(e => e.Endereco).ToListAsync();
            return View(atletas);
        }

        [HttpGet("Criar")]
        public ActionResult Create()
        {
            var modalidades = _context.Modalidades.ToList();
            var model = new DirigenteCreateViewModel(modalidades);
            return View(model);
        }
        [HttpGet("Termo")]
        public ActionResult Termo(int id)
        {
            //var modalidades = _context.Modalidades.ToList();
            //var model = new DirigenteCreateViewModel(modalidades);
            //var dirigente = _context.Dirigentes.FirstOrDefault(i => i.Id == id);
            //return View(dirigente);
            return View();
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
        public async Task<ActionResult> Edit(int id)
        {
            var dirigente = await _context.Dirigentes.Include(a => a.Endereco).FirstOrDefaultAsync(e => e.Id == id);
            return View(dirigente);
        }

        [HttpPost("Editar")]
        public async Task<ActionResult> Edit(Dirigente dirigente)
        {
            var dirigenteBanco = await _context.Dirigentes.Include(a => a.Endereco).FirstOrDefaultAsync(e => e.Id == dirigente.Id);
            dirigenteBanco.Atualiza(dirigente);

            _context.Update(dirigenteBanco);
            await _context.SaveChangesAsync();
            return View();
        }


        [HttpGet("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            var atleta = await _context.Dirigentes.FirstOrDefaultAsync(e => e.Id == id);
            return View(atleta);
        }

        [HttpPost("Delete")]
        public async Task<ActionResult> Delete(Dirigente dirigente)
        {
            var dirigenteBanco = await _context.Dirigentes.FirstOrDefaultAsync(e => e.Id == dirigente.Id);
            _context.Remove(dirigenteBanco);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
