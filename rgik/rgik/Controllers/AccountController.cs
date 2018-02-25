using rgik.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }


        /// <summary>
        /// When user sends the request to login in
        /// </summary>
        /// <param name="model">The form that was sent</param>
        /// <param name="ReturnUrl"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(LoginViewModel model,string ReturnUrl)
        {
            //Model was not done properly
            if (!(ModelState.IsValid))
                return View(model);
            else
                return RedirectToAction("Index", "Home");
            
        }

        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// When user sends the request to register
        /// </summary>
        /// <param name="model">The form that was sent</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (!(ModelState.IsValid))
                return View(model);
            else
                return RedirectToAction("Index", "Home");
        }
    }
}