using AtletaAsdericel.Data;
using AtletaAsdericel.Services;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
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
            return View();
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
            catch(Exception e)
            {
                return View(viewModel);
            }
        }

        // GET: AtletaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtletaController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AtletaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtletaController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
