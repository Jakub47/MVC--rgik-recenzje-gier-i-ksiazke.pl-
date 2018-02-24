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


//[OutputCache(Duration = 60000)]
//public ActionResult Pozycje(string typPlatformy)
//{
//    var platforma = db.Platforma.Where(p => p.NazwaPlatformy == typPlatformy).ToList();
//    var gry = db.Gra.Where(p => p.PlatformaId == platforma.OrderBy(k => Guid.NewGuid()).Single().PlatformaId).ToList();

//    return View(typPlatformy,gry);
//}