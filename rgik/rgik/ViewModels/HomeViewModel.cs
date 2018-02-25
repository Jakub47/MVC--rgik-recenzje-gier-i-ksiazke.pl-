using rgik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rgik.ViewModels
{
    public class HomeViewModel
    {
        //Define Properties for Games
        public IEnumerable<Gra> GryNajlepiejOcenianie { get; set; }

        //Define properties for Books
        public IEnumerable<Ksiazka> KsiazkiNajlepiejOceniane { get; set; }
    }
}