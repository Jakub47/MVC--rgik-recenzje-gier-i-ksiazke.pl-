using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace rgik
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Platforma-Windows
            routes.MapRoute(
                name: "Platforma",
                url: "Pozycje-{nazwa}",
                defaults: new { controller = "Platforma", action = "Pozycje" }
            );

            //Pozycje-Horror
            routes.MapRoute(
                name: "Gatunek",
                url: "Elementy-{nazwa}",
                defaults: new { controller = "Gatunek", action = "Elementy" }
            );

            //Recenzja-Gry-Gothic
            routes.MapRoute(
                name: "RecenzjaGry",
                url: "Recenzja-Gry-{nazwa}",
                defaults: new { controller = "Gra", action = "Recenzja" }
            );

            //Recenzja-Ksiazki-Inni
            routes.MapRoute(
                name: "RecenzjaKsiazki",
                url: "Recenzja-Ksiazki-{nazwa}",
                defaults: new { controller = "Ksiazka", action = "Recenzja" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
