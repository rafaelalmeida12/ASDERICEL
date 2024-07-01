using AtletaAsdericel.Data;
using AtletaAsdericel.Models;
using AtletaAsdericel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Controllers
{
    public class ModalidadeController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        public ModalidadeController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var modalidades = await _contexto.Modalidades.Include(m => m.ModalidadeCategorias).ToListAsync();
            return View(modalidades);
        }
        public IActionResult Create()
        {
            var model = new ModalidadeCreateViewModel()
            {
                Categorias = new SelectList(_contexto.Categorias, "Id", "Nome"),
                Sexos = new SelectList(_contexto.Sexo, "Id", "Nome")
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ModalidadeCreateViewModel viewModel)
        {
           
                var categorias = await _contexto.Categorias
                    .Where(c => viewModel.CategoriaIds.Contains(c.Id))
                    .ToListAsync();

                var sexos = await _contexto.Sexo
                    .Where(s => viewModel.SexoIds.Contains(s.Id))
                    .ToListAsync();

                var modalidade = new Modalidade
                {
                    Nome = viewModel.Nome,
                    ModalidadeCategorias = categorias.Select(c => new ModalidadeCategoria
                    {
                        CategoriaId = c.Id
                    }).ToList(),
                    ModalidadeSexos = sexos.Select(s => new ModalidadeSexo
                    {
                        SexoId = s.Id
                    }).ToList()
                };

                _contexto.Modalidades.Add(modalidade);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }
        [HttpGet("Editar")]
        public async Task<ActionResult> Edit(int id)
        {
            var atleta = await _contexto.Modalidades.FirstOrDefaultAsync(e => e.Id == id);
            return View(atleta);
        }

        [HttpPost("Editar")]
        public async Task<ActionResult> Edit(Modalidade modalidade)
        {
            var atletaBanco = await _contexto.Modalidades.FirstOrDefaultAsync(e => e.Id == modalidade.Id);
            atletaBanco.Atualiza(modalidade);

            _contexto.Update(atletaBanco);
            await _contexto.SaveChangesAsync();
            return View();
        }
    }
}
