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
            string search = "";
            if (nazwa.Equals("Windows")) search = "PC";
            var platforma = db.Platforma.Where(p => p.NazwaPlatformy.Equals(search)).ToList();

            //actions = db.Actions.Where(a => search.Any(s => a.Agent.Contains(s)));
            var gry = platforma.Select(a => a.Gry).ToList();
            if (gry == null)
            {
                var gatunki = db.Gatunek.Where(g => g.NazwaGatunku == nazwa).ToList();
                var ksiazki = gatunki.Select(a => a.Ksiazka).ToList();
                return View(nazwa, ksiazki);
            }
            //var cutomers = from c in Customers
            //where cities.Contains(c.City)
            //select c;

            Console.WriteLine("some Code");
            return View(nazwa, gry); //My tutaj nie przekazujemy obiektu jaki ma zostać wyświetlnoy tylko jaki widok ma zostać wyświetlnoy
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



//int element = 0; var gry = new List<Gra>();
//foreach(var item in db.Gra)
//{
//    if (item.PlatformaId == platforma.ElementAt(element).PlatformaId)
//        gry.Add(item);
//    element++;
//}