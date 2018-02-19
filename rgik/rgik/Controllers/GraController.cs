using rgik.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Controllers
{
    public class GraController : Controller
    {
        private rgikContext db = new rgikContext();

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]   //<-- Akcja mogąca zostać wywołana tylko z poziomu innej akcji
        public ActionResult GenerateRandomGames()
        {
            var gry = db.Gra.OrderBy(g => Guid.NewGuid()).Take(2).ToList();
            return PartialView("_RandomGames",gry);
        }

        public ActionResult Recenzja(string nazwa)
        {
            var gra = db.Gra.Where(n => n.NazwaGry == nazwa).Single();

            #region Validation
            if (gra == null)
            {
                ViewBag.Blad = "Błąd";
                return  RedirectToAction("Index", "Home");
            }
            #endregion

            return View(gra);
        }
    }
}