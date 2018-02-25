using rgik.DAL;
using rgik.Infrastucture;
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
            ICacheProvider cache = new DefaultCacheProvider();

            List<Gra> gryNajlepiejOceniane;
            if(cache.isSet(Consts.NajlepszeGryCacheKey))
            {
                //If our key exist that mean we have this object/value stored in cache
                gryNajlepiejOceniane = cache.Get(Consts.NajlepszeGryCacheKey) as List<Gra>;
            }
            else
            {
                //If our key does not exist that mean we must place that in cache
                gryNajlepiejOceniane = db.Gra.OrderByDescending(g => g.Ocena).Take(2).ToList();
                cache.Set(Consts.NajlepszeGryCacheKey, gryNajlepiejOceniane, 60); 
            }

            List<Ksiazka> ksiazkiNajlepiejOceniane;
            if(cache.isSet(Consts.NajlepszeKsiazkiCacheKey))
            {
                ksiazkiNajlepiejOceniane = cache.Get(Consts.NajlepszeKsiazkiCacheKey) as List<Ksiazka>;
            }
            else
            {
                ksiazkiNajlepiejOceniane = db.Ksiazka.OrderByDescending(k => k.Ocena).Take(2).ToList();
                cache.Set(Consts.NajlepszeKsiazkiCacheKey, ksiazkiNajlepiejOceniane, 60);
            }

            var vm = new HomeViewModel
            {
                GryNajlepiejOcenianie = gryNajlepiejOceniane,
                KsiazkiNajlepiejOceniane = ksiazkiNajlepiejOceniane
            };

            return View(vm);
        }
    }
}