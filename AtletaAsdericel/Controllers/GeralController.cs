using AtletaAsdericel.Data;
using AtletaAsdericel.Models;
using AtletaAsdericel.Services;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class GeralController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly CorreiosService _correiosService;

        public GeralController(CorreiosService correiosService, ApplicationDbContext context)
        {
            _correiosService = correiosService;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var atletas = await _context.Associado.Include(e => e.Endereco).ToListAsync();
            return View(atletas);
        }
        [HttpGet("Criar")]
        public async Task<ActionResult> Create()
        {
            var model = new GeralCreateViewModel();
            return View(model);
        }

        // GET: AtletaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: AtletaController1/Create
        [ValidateAntiForgeryToken]
        [HttpPost("Criar")]
        public ActionResult Create(GeralCreateViewModel viewModel)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(viewModel);
                }
                _context.Associado.Add(viewModel.ToEntity());
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View(viewModel);
            }
        }
        [HttpGet("Editar")]

        public async Task<ActionResult> Edit(int id)
        {
            var geral = await _context.Associado.Include(e=>e.Endereco).FirstOrDefaultAsync(a => a.Id == id);
            return View(geral);
        }
        [HttpPost("Editar")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Associado associado)
        {
            try
            {
                var associadoBanco = await _context.Associado.Include(e => e.Endereco).FirstOrDefaultAsync(e => e.Id == associado.Id);
                associadoBanco.Atualiza(associado);

                _context.Update(associadoBanco);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [HttpGet("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            var associado = await _context.Associado.FirstOrDefaultAsync(e => e.Id == id);
            return View(associado);
        }

        [HttpPost("Delete")]
        public async Task<ActionResult> Delete(Associado associado)
        {
            var atletaBanco = await _context.Associado.FirstOrDefaultAsync(e => e.Id == associado.Id);
            _context.Remove(atletaBanco);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
