using rgik.DAL;
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

        public ActionResult Pozycje(string typPlatformy)
        {
            var platforma = db.Platforma.Where(p => p.NazwaPlatformy == typPlatformy).ToList();
            var gry = db.Gra.Where(p => p.PlatformaId == platforma.OrderBy(k => Guid.NewGuid()).Single().PlatformaId).ToList();

            return View(gry);
        }
    }
}