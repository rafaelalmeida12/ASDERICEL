using AtletaAsdericel.Data;
using AtletaAsdericel.Models;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    [Authorize]
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
        [HttpGet("Termo")]
        public ActionResult Termo(int id)
        {
            //var modalidades = _context.Modalidades.ToList();
            //var model = new DirigenteCreateViewModel(modalidades);
            //var dirigente = _context.Dirigentes.FirstOrDefault(i => i.Id == id);
            //return View(dirigente);
            return View();
        }
        [HttpGet("Editar")]
        public async Task<ActionResult> Edit(int id)
        {
            var atleta = await _context.Atletas.Include(a=>a.Escola).Include(a=>a.Endereco).FirstOrDefaultAsync(e => e.Id == id);
            ViewBag.Modalidades = _context.Modalidades
                                             .Select(m => new SelectListItem
                                             {
                                                 Value = m.Id.ToString(), 
                                                 Text = m.Nome 
                                             }).ToList();
            return View(atleta);
        }

        [HttpPost("Editar")]
        public async Task<ActionResult> Edit(Atleta atleta)
        {
            var atletaBanco = await _context.Atletas.Include(a => a.Escola).Include(a => a.Endereco).FirstOrDefaultAsync(e => e.Id == atleta.Id);
            atletaBanco.Atualiza(atleta);

            _context.Update(atletaBanco);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
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
