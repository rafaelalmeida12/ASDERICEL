using AtletaAsdericel.Data;
using AtletaAsdericel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace federacaoAsdericel.Controllers
{
	[Authorize]
	[Route("[controller]")]
	public class FederacaoController : Controller
	{
		private readonly ApplicationDbContext _context;
		public FederacaoController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult> Index()
		{
			var federacaos = await _context.Federacao.ToListAsync();
			return View(federacaos);
		}
		[HttpGet("Criar/{id?}")]
		public ActionResult Create(int? id)
		{
			if (id.HasValue)
			{
				var federacao = _context.Federacao.Find(id.Value);
				if (federacao == null)
					return NotFound();

				return View(federacao);
			}
			return View(new Federacao());
		}
		[HttpPost("Criar/{id?}")]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Federacao model)
		{
			try
			{
				if (!ModelState.IsValid)
					return View(model);
				if (model.Id == 0)
					_context.Federacao.Add(model);
				else
					_context.Federacao.Update(model);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				return View(model);
			}
		}

		[HttpGet("Delete/{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var federacaoBanco = await _context.Federacao.FirstOrDefaultAsync(e => e.Id == id);
			_context.Remove(federacaoBanco);
			await _context.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}

		// POST: FederacaoController/Edit/5
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
	}
}
