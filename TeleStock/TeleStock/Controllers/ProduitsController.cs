using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeleStock.Models;

namespace TeleStock.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly ProjectContext _context;

        public ProduitsController(ProjectContext context)
        {
            _context = context;
        }

        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            List<Produit> produitList = _context.Produits.ToList<Produit>();
            return Json(new { data = produitList });
        }


        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Produit());
            else
            {
                return View(_context.Produits.Where(x => x.produitID == id).FirstOrDefault<Produit>());
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(Produit produit)
        {
            if (produit.produitID == 0)
            {
                _context.Produits.Add(produit);
                _context.SaveChanges();
                return Json(new { success = true, message = "Saved Successfully" });
            }
            else if (_context.Produits.Any(e => e.produitID == produit.produitID))
            {
                _context.Entry(produit).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { success = true, message = "Updated Successfully" });
            }
            else
                return Json(new { success = false, message = "No Update" });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Produit emp = _context.Produits.Where(x => x.produitID == id).FirstOrDefault<Produit>();
            _context.Produits.Remove(emp);
            _context.SaveChanges();
            return Json(new { success = true, message = "Deleted Successfully" });
        }




















        //private readonly ProjectContext _context;

        //public ProduitsController(ProjectContext context)
        //{
        //    _context = context;
        //}

        //// GET: Produits
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Produits.ToListAsync());
        //}

        //// GET: Produits/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var produit = await _context.Produits
        //        .SingleOrDefaultAsync(m => m.produitID == id);
        //    if (produit == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(produit);
        //}

        //// GET: Produits/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Produits/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("produitID,codeProduit,refProduit,desProduit,prixVenteHtProduit,prixAchatHtProduit,tvaProduit,qteEnStockProduit,qteRuptureProduit,qteSurStockProduit,remarqueProduit")] Produit produit)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(produit);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(produit);
        //}

        //// GET: Produits/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var produit = await _context.Produits.SingleOrDefaultAsync(m => m.produitID == id);
        //    if (produit == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(produit);
        //}

        //// POST: Produits/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("produitID,codeProduit,refProduit,desProduit,prixVenteHtProduit,prixAchatHtProduit,tvaProduit,qteEnStockProduit,qteRuptureProduit,qteSurStockProduit,remarqueProduit")] Produit produit)
        //{
        //    if (id != produit.produitID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(produit);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProduitExists(produit.produitID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(produit);
        //}

        //// GET: Produits/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var produit = await _context.Produits
        //        .SingleOrDefaultAsync(m => m.produitID == id);
        //    if (produit == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(produit);
        //}

        //// POST: Produits/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var produit = await _context.Produits.SingleOrDefaultAsync(m => m.produitID == id);
        //    _context.Produits.Remove(produit);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ProduitExists(int id)
        //{
        //    return _context.Produits.Any(e => e.produitID == id);
        //}
    }
}
