using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace rgik.Infrastucture
{
    public class AppConfig
    {
        private static string _obrazekFolderWzgledny = ConfigurationManager.AppSettings["ObrazkiFolder"];
        public static string ObrazekFolderWzgledny
        {
            get
            {
                return _obrazekFolderWzgledny;
            }
        }
    }
}