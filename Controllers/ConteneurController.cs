using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Models;
using GestionDesArchivesWebApp.Data;
using System.Runtime.CompilerServices;
namespace GestionDesArchivesWebApp.Controllers
{
    public class ConteneurController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConteneurController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Conteneur
        public async Task<IActionResult> Index(
    DateTime? startDate,
    DateTime? endDate,
    string cdeCon,
    string desCon,
    string NomPrePer,  // Filtrage par NomPrePer
    string DesTypClass,
    string DesSupp,
    string DesSoc,
    bool? archiver,
    string desEmpl,
    string DesStd
)
        {
            ViewBag.DesConOptions = await _context.Conteneurs.Select(c => c.DesCon).Distinct().ToListAsync();
            ViewBag.CodePerOptions = await _context.Personnels.Select(p => p.NomPrePer).Distinct().ToListAsync();
            ViewBag.CodeTypClassOptions = await _context.TypeClassements.Select(t => t.DesTypClass).Distinct().ToListAsync();
            ViewBag.CodeSupOptions = await _context.Supports.Select(s => s.DesSupp).Distinct().ToListAsync();
            ViewBag.CodeStdOptions = await _context.StadeClassements.Select(sc => sc.DesStd).Distinct().ToListAsync();
            ViewBag.Societes = await _context.Societes.Select(s => s.DesSoc).Distinct().ToListAsync();
            ViewBag.Emplacements = await _context.Emplacements.Select(e => e.DesEmpl).Distinct().ToListAsync();

            var query = from c in _context.Conteneurs
                        join e in _context.Emplacements on c.CdeEmpl equals e.CdeEmpl into ce
                        from e in ce.DefaultIfEmpty()
                        join s in _context.Societes on c.CdeSoc equals s.CdeSoc into cs
                        from s in cs.DefaultIfEmpty()
                        join t in _context.TypeClassements on c.CdeTypClass equals t.CdeTypClass into ct
                        from t in ct.DefaultIfEmpty()
                        join p in _context.Personnels on c.CdePer equals p.CdePer into cp
                        from p in cp.DefaultIfEmpty()
                        join sc in _context.StadeClassements on c.CdeStd equals sc.CdeStd into csc
                        from sc in csc.DefaultIfEmpty()
                        join sup in _context.Supports on c.CdeSup equals sup.CdeSup into csup
                        from sup in csup.DefaultIfEmpty()
                        select new { Conteneur = c, Emplacement = e, Societe = s, TypeClassement = t, Personnel = p, StadeClassement = sc, Support = sup };

            // Appliquer les filtres
            if (startDate.HasValue)
            {
                query = query.Where(ce => ce.Conteneur.SutDeb >= startDate);
            }

            if (endDate.HasValue)
            {
                query = query.Where(ce => ce.Conteneur.SutFin <= endDate);
            }

            if (!string.IsNullOrEmpty(cdeCon))
            {
                query = query.Where(ce => ce.Conteneur.CdeCon.Contains(cdeCon));
            }

            if (!string.IsNullOrEmpty(desCon))
            {
                query = query.Where(ce => ce.Conteneur.DesCon.Contains(desCon));
            }

            if (!string.IsNullOrEmpty(NomPrePer))
            {
                query = query.Where(ce => ce.Personnel != null && ce.Personnel.NomPrePer.Contains(NomPrePer));
            }

            if (!string.IsNullOrEmpty(DesTypClass))
            {
                query = query.Where(ce => ce.TypeClassement != null && ce.TypeClassement.DesTypClass.Contains(DesTypClass));
            }

            if (!string.IsNullOrEmpty(DesSupp))
            {
                query = query.Where(ce => ce.Support != null && ce.Support.DesSupp.Contains(DesSupp));
            }

            if (!string.IsNullOrEmpty(DesStd))
            {
                query = query.Where(ce => ce.StadeClassement != null && ce.StadeClassement.DesStd.Contains(DesStd));
            }

            if (!string.IsNullOrEmpty(DesSoc))
            {
                query = query.Where(ce => ce.Societe != null && ce.Societe.DesSoc.Contains(DesSoc));
            }

            if (!string.IsNullOrEmpty(desEmpl))
            {
                query = query.Where(ce => ce.Emplacement != null && ce.Emplacement.DesEmpl.Contains(desEmpl));
            }

            if (archiver.HasValue)
            {
                query = query.Where(ce => ce.Conteneur.Archiver == archiver.Value);
            }

            var result = await query.ToListAsync();
            var conteneurs = result.Select(r => r.Conteneur).ToList();

            return View(conteneurs);
        }




        // GET: Conteneur/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Récupérer le conteneur
            var conteneur = await _context.Conteneurs
                .FirstOrDefaultAsync(m => m.CdeCon == id);

            if (conteneur == null)
            {
                return NotFound();
            }

            // Récupérer les contenus associés
            var contenus = await _context.Contenus
                .Where(c => c.CdeCon == id)
                .ToListAsync();

            // Créer un modèle pour la vue
            var viewModel = new ConteneurDetailsViewModel
            {
                Conteneur = conteneur,
                Contenus = contenus
            };

            return View(viewModel);
        }

        // GET: Conteneur/Create
        public IActionResult Create()
        {
            PopulateViewData();
            return View();
        }

        // POST: Conteneur/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CdeCon,DesCon,SutDeb,SutFin,DurVieCon,CdePer,CdeEmpl,CdeTypClass,CdeSup,CdeStd,CdeSoc,Archiver,DispoAdx,suiteD,suiteF")] Conteneur conteneur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conteneur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateViewData(conteneur);
            return View(conteneur);
        }

        // GET: Conteneur/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conteneur = await _context.Conteneurs.FindAsync(id);
            if (conteneur == null)
            {
                return NotFound();
            }
            PopulateViewData(conteneur);
            return View(conteneur);
        }

        // POST: Conteneur/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CdeCon,DesCon,SutDeb,SutFin,DurVieCon,CdePer,CdeEmpl,CdeTypClass,CdeSup,CdeStd,CdeSoc,Archiver,DispoAdx,suiteD,suiteF")] Conteneur conteneur)
        {
            if (id != conteneur.CdeCon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conteneur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConteneurExists(conteneur.CdeCon))
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
            PopulateViewData(conteneur);
            return View(conteneur);
        }

        // GET: Conteneur/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conteneur = await _context.Conteneurs
                .FirstOrDefaultAsync(m => m.CdeCon == id);
            if (conteneur == null)
            {
                return NotFound();
            }

            return View(conteneur);
        }

        // POST: Conteneur/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var conteneur = await _context.Conteneurs.FindAsync(id);
            _context.Conteneurs.Remove(conteneur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConteneurExists(string id)
        {
            return _context.Conteneurs.Any(e => e.CdeCon == id);
        }

        // Populate dropdown lists for Create/Edit views
        private void PopulateViewData(Conteneur conteneur = null)
        {
            ViewData["CdeEmpl"] = new SelectList(_context.Emplacements, "CdeEmpl", "DesEmpl", conteneur?.CdeEmpl);
            ViewData["PersonnelOptions"] = new SelectList(_context.Personnels, "CdePer", "NomPrePer", conteneur?.CdePer);
            ViewData["TypeClassementOptions"] = new SelectList(_context.TypeClassements, "CdeTypClass", "DesTypClass", conteneur?.CdeTypClass);
            ViewData["SupportOptions"] = new SelectList(_context.Supports, "CdeSup", "DesSupp", conteneur?.CdeSup);
            ViewData["StadeClassementOptions"] = new SelectList(_context.StadeClassements, "CdeStd", "DesStd", conteneur?.CdeStd);
            ViewData["SocieteOptions"] = new SelectList(_context.Societes, "CdeSoc", "DesSoc", conteneur?.CdeSoc);
        }

        // GET: Conteneur/ContenuDetails/5
        // GET: Conteneur/ContenuDetails/5
        public async Task<IActionResult> ContenuDetails(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenu = await _context.Contenus
                .FirstOrDefaultAsync(c => c.CdePiece == id);

            if (contenu == null)
            {
                return NotFound();
            }

            return View(contenu);
        }

    }
}
