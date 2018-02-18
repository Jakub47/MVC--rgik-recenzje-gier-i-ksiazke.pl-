using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rgik.Infrastucture
{
    public static class UrlHelpers
    {
        public static string ObrazkiSciezka(this UrlHelper helper, string nazwaObrazka )
        {
            var ObrazkiKategoriFolder = AppConfig.ObrazkiFolderWzgledny;
            var sciezka = Path.Combine(ObrazkiKategoriFolder, nazwaObrazka);
            var sciezkaBezwzledna = helper.Content(sciezka);

            return sciezkaBezwzledna;
        }
    }
}