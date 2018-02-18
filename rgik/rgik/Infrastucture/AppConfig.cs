using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace rgik.Infrastucture
{
    /// <summary>
    /// Konektor do Web.config
    /// </summary>
    public class AppConfig
    {
        private static string _obrazkiFolderWzgledny = ConfigurationManager.AppSettings["ObrazkiFolder"];

        public static string ObrazkiFolderWzgledny
        {
            get
            {
                return _obrazkiFolderWzgledny;
            }  
        }
    }
}