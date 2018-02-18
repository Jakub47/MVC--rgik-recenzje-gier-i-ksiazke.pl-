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
        public static string ObrazkiKategoriaSciezka(this UrlHelper helper, string plik)
        {
            var obrazkiFolder = AppConfig.ObrazekFolderWzgledny;
            var sciezka = Path.Combine(obrazkiFolder, plik);
            var sciezkaBezWzledna = helper.Content(sciezka);

            return sciezkaBezWzledna;
        }
    }
}