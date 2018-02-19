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
        private rgikContext db = new rgikContext();

        public ActionResult Index()
        {
            var windows = db.Gra.ToList();
            return View(windows);
        }

        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa); //My tutaj nie przekazujemy obiektu jaki ma zostać wyświetlnoy tylko jaki widok ma zostać wyświetlnoy
        }
    }
}


//var dwieLosoweGry = db.Gra.OrderBy(g => Guid.NewGuid()).Take(2).ToList();
//var dwieLosoweKsiazki = db.Ksiazka.OrderBy(k => Guid.NewGuid()).Take(2).ToList();
//var windows = db.Gra.Where(w => w.PlatformaId == 1).ToList();

//var vm = new HomeViewModel
//{
//    Windows = windows,
//    GryLosowe = dwieLosoweGry,
//    KsiazkaLosowe = dwieLosoweKsiazki
//};