using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Controllers
{
    public class WerController : Controller
    {
        // GET: Wer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ops()
        {
            return View();
        }
    }
}