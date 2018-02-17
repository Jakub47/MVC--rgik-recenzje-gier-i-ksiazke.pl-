using rgik.DAL;
using rgik.Models;
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
            var gry = db.Gra.ToList();
            return View(gry);
        }
    }
}