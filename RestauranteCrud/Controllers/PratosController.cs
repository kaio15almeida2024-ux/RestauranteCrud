using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestauranteCrud.Data;
using RestauranteCrud.Models;

namespace RestauranteCrud.Controllers
{
    public class PratosController : Controller
    {
        private readonly RestauranteContext _context;

        public PratosController(RestauranteContext context)
        {
            _context = context;
        }

        // GET: Pratos
        public async Task<IActionResult> Index()
        {
            var restauranteContext = _context.Prato
                .Include(p => p.Fornecedor);

            return View(await restauranteContext.ToListAsync());
        }

        // GET: Pratos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pratos = await _context.Prato
                .Include(p => p.Fornecedor)
                .FirstOrDefaultAsync(m => m.IdPrato == id);

            if (pratos == null)
            {
                return NotFound();
            }

            return View(pratos);
        }

        // GET: Pratos/Create
        public IActionResult Create()
        {
            ViewData["IdFornecedor"] = new SelectList(
                _context.Fornecedores,
                "IdFornecedor",
                "NomeFornecedor"
            );

            return View();
        }

        // POST: Pratos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("IdPrato,NomePrato,Descricao,Preco,Categoria,IdFornecedor,DataCadastro")] Pratos pratos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pratos);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewData["IdFornecedor"] = new SelectList(
                _context.Fornecedores,
                "IdFornecedor",
                "NomeFornecedor",
                pratos.IdFornecedor
            );

            return View(pratos);
        }

        // GET: Pratos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pratos = await _context.Prato.FindAsync(id);

            if (pratos == null)
            {
                return NotFound();
            }

            ViewData["IdFornecedor"] = new SelectList(
                _context.Fornecedores,
                "IdFornecedor",
                "NomeFornecedor",
                pratos.IdFornecedor
            );

            return View(pratos);
        }

        // POST: Pratos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            [Bind("IdPrato,NomePrato,Descricao,Preco,Categoria,IdFornecedor,DataCadastro")] Pratos pratos)
        {
            if (id != pratos.IdPrato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pratos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PratosExists(pratos.IdPrato))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["IdFornecedor"] = new SelectList(
                _context.Fornecedores,
                "IdFornecedor",
                "NomeFornecedor",
                pratos.IdFornecedor
            );

            return View(pratos);
        }

        // GET: Pratos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pratos = await _context.Prato
                .Include(p => p.Fornecedor)
                .FirstOrDefaultAsync(m => m.IdPrato == id);

            if (pratos == null)
            {
                return NotFound();
            }

            return View(pratos);
        }

        // POST: Pratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pratos = await _context.Prato.FindAsync(id);

            if (pratos != null)
            {
                _context.Prato.Remove(pratos);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool PratosExists(int id)
        {
            return _context.Prato.Any(e => e.IdPrato == id);
        }
    }
}