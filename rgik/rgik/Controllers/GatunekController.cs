using rgik.DAL;
using rgik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Controllers
{
    public class GatunekController : Controller
    {
        private rgikContext db = new rgikContext();

        // GET: Gatunek
        public ActionResult Index()
        {
            return View();
        }


        [OutputCache(Duration = 60000)]
        public ActionResult Elementy(string nazwaGatunku)
        {

            int gatunekId = db.Gatunek.Where(p => p.NazwaGatunku.Equals(nazwaGatunku)).Select(n => n.GatunekId).Single();
            List<Ksiazka> ksiazki = db.Ksiazka.Where(g => g.GatunekId == gatunekId).ToList();
            if (ksiazki == null)
            {
                ViewBag.Error = "Brak gier na tej platformie!";
                return RedirectToAction("Index", "Home");
            }

            return View(ksiazki);
        }
    }
}