using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.UI.Controllers
{
    public class PrestationController : Controller
    {
        // GET: PrestationController
        IServicePrestation pss;
        IServicePrestataire sp;

        public PrestationController(IServicePrestation pss, IServicePrestataire sp)
        {
            this.pss = pss;
            this.sp = sp;
        }

        public ActionResult Index(int? id)
        {
            if(id==null)
                return View(pss.GetAll());
            return View(pss.GetMany(p=>p.PrestataireFk==id));




        }

        // GET: PrestationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestationController/Create
        public ActionResult Create()
        {
            var allPrestataires = sp.GetAll()
.ToList();
            ViewBag.PrestataireList = new SelectList(allPrestataires, "PrestataireId", "PrestataireNom");

            return View();
        }

        // POST: PrestationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestation prestation)
        {
            try
            {
                var allPrestataires = sp.GetAll()
    .ToList();
                ViewBag.PrestataireList = new SelectList(allPrestataires, "PrestataireId", "PrestataireNom");

                pss.Add(prestation);
                pss.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestationController/Edit/5
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

        // GET: PrestationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestationController/Delete/5
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
