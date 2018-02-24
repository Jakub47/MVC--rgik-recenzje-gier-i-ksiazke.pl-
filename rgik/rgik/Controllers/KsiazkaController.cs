using rgik.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Controllers
{
    public class KsiazkaController : Controller
    {
        private rgikContext db = new rgikContext();

        // GET: Ksiazka
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 60000)]
        public ActionResult Recenzja(string nazwa)
        {
            var gra = db.Ksiazka.Where(n => n.NazwaKsiazki == nazwa).Single();

            #region Validation
            if (gra == null)
            {
                ViewBag.Blad = "Błąd";
                return RedirectToAction("Index", "Home");
            }
            #endregion

            return View(gra);
        }
    }
}