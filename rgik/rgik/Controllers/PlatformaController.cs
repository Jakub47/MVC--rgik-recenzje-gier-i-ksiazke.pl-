using rgik.DAL;
using rgik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Controllers
{
    public class PlatformaController : Controller
    {
        private rgikContext db = new rgikContext();

        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 60000)]
        public ActionResult Pozycje(string nazwa)
        {
            string search = "";
            if (nazwa.Equals("Windows")) search = "PC";
            else search = nazwa;

            int platformaId = db.Platforma.Where(p => p.NazwaPlatformy.Equals(search)).Select(n => n.PlatformaId).Single();
            List<Gra> gry = db.Gra.Where(g => g.PlatformaId == platformaId).ToList();
            if (gry == null)
            {
                ViewBag.Error = "Brak gier na tej platformie!";
                return RedirectToAction("Index", "Home");
            }

            return View(gry); 
        }
    }
}