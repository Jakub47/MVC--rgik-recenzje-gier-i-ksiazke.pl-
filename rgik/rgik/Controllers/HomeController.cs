using rgik.DAL;
using rgik.Models;
using rgik.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        private rgikContext db = new rgikContext();

        public ActionResult Index()
        {
            var dwieLosoweGry = db.Gra.OrderBy(g => Guid.NewGuid()).Take(2).ToList();
            var dwieLosoweKsiazki = db.Ksiazka.OrderBy(k => Guid.NewGuid()).Take(2).ToList();
            var windows = db.Gra.Where(w => w.PlatformaId == 1).ToList();

            var vm = new HomeViewModel
            {
                Windows = windows,
                GryLosowe = dwieLosoweGry,
                KsiazkaLosowe = dwieLosoweKsiazki
            };

            return View(vm);
        }

        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa); //My tutaj nie przekazujemy obiektu jaki ma zostać wyświetlnoy tylko jaki widok ma zostać wyświetlnoy
        }
    }
}