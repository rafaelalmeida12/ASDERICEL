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
    public class ModalidadeController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        public ModalidadeController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var modalidades = await _contexto.Modalidades
                .Include(m => m.ModalidadeCategorias).ThenInclude(m => m.Categoria)
                .Include(m => m.ModalidadeSexos).ThenInclude(m => m.Sexo)
                .ToListAsync();
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
            var modalidade = await _contexto.Modalidades
            .Include(m => m.ModalidadeCategorias).ThenInclude(m => m.Categoria)
            .Include(m => m.ModalidadeSexos).ThenInclude(m => m.Sexo)
            .FirstOrDefaultAsync(e => e.Id == id);

            var model = new ModalidadeEditViewModel()
            {
                Id = id,
                Nome = modalidade.Nome,
                Categorias = new SelectList(_contexto.Categorias, "Id", "Nome", modalidade.ModalidadeCategorias),
                Sexos = new SelectList(_contexto.Sexo, "Id", "Nome", modalidade.ModalidadeSexos)
            };
            return View(model);
        }

        [HttpPost("Editar")]
        public async Task<ActionResult> Edit(ModalidadeEditViewModel viewModel)
        {
            var modalidadeBanco = await _contexto.Modalidades
                .Include(m => m.ModalidadeSexos)
                .Include(m => m.ModalidadeCategorias)
                .FirstOrDefaultAsync(e => e.Id == viewModel.Id);

            if (modalidadeBanco == null)
                return NotFound();

            modalidadeBanco.ModalidadeSexos.Clear();
            modalidadeBanco.ModalidadeCategorias.Clear();

            var sexos = await _contexto.Sexo
                .Where(ms => viewModel.SexoIds.Contains(ms.Id))
                .ToListAsync();

            var categorias = await _contexto.Categorias
                .Where(mc => viewModel.CategoriaIds.Contains(mc.Id))
                .ToListAsync();

            // Atualizar a Modalidade no contexto e salvar as alterações
            modalidadeBanco.ModalidadeCategorias = categorias.Select(c => new ModalidadeCategoria
            {
                CategoriaId = c.Id
            }).ToList();
            modalidadeBanco.ModalidadeSexos = sexos.Select(s => new ModalidadeSexo
            {
                SexoId = s.Id
            }).ToList();
            modalidadeBanco.Nome = viewModel.Nome;
            _contexto.Modalidades.Update(modalidadeBanco);
            await _contexto.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
