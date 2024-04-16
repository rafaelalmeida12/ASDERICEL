using AtletaAsdericel.Data;
using AtletaAsdericel.Models;
using AtletaAsdericel.Services;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.ConstrainedExecution;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AtletaAsdericel.Controllers
{
    [Route("[controller]")]
    public class CadastroController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly CorreiosService _correiosService;

        public CadastroController(CorreiosService correiosService, ApplicationDbContext context)
        {
            _correiosService = correiosService;
            _context = context;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {

            var atletas = await _context.Associado.Include(e => e.Endereco).ToListAsync();
            return View(atletas);
        }

        // GET: AtletaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet("Geral")]
        public async Task<ActionResult> Create()
        {
           var endereco = await _correiosService.BuscarEnderecoPorCep("76813040");

            var cidades = _context.Cidades.ToList();
            var estados = _context.Estados.ToList();
            var responsaveis = _context.Responsavel.ToList();
            var model = new GeralCreateViewModel()
            {
                Cidades = cidades,
                Estados = estados,
                Responsaveis = responsaveis
            };
            return View(model);
        }

        [HttpGet("Dirigente")]
        public ActionResult CreateDirigente()
        {
            var cidades = _context.Cidades.ToList();
            var estados = _context.Estados.ToList();
            var responsaveis = _context.Responsavel.ToList();
            var modalidades = _context.Modalidades.ToList();
            var model = new DirigenteCreateViewModel()
            {
                Cidades = cidades,
                Estados = estados,
                Modalidades = modalidades
            };
            return View(model);
        }

        [HttpGet("Atleta")]
        public ActionResult CreateAtleta()
        {
            var cidades = _context.Cidades.ToList();
            var estados = _context.Estados.ToList();
            var responsaveis = _context.Responsavel.ToList();
            var modalidades = _context.Modalidades.ToList();
            var model = new AtletaCreateViewModel()
            {
                Cidades = cidades,
                Estados = estados,
                Responsaveis = responsaveis,
                Modalidades = modalidades
            };
            return View(model);
        }

        // POST: AtletaController1/Create
        [HttpPost("Geral")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GeralCreateViewModel viewModel)
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
