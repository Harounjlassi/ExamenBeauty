using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB.UI.Controllers
{
    public class PrestataireController : Controller
    {
        IServicePrestataire sp;

        public PrestataireController(IServicePrestataire sp)
        {
            this.sp = sp;
        }

        // GET: PrestataireController
        //https://localhost:7066/Prestataire/Index
        public ActionResult Index(string nom)
        {
            if(nom == null)
                return View(sp.GetAll().OrderBy(p=>p.PrestataireNom));
            return View(sp.GetMany(p=>p.PrestataireNom==nom).OrderBy(p => p.PrestataireNom));

        }

        // GET: PrestataireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestataireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestataireController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PrestataireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestataireController/Edit/5
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

        // GET: PrestataireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestataireController/Delete/5
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
