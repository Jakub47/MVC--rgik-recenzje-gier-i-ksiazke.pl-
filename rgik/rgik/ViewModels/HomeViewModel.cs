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
        public IEnumerable<Gra> Windows { get; set; }
        public IEnumerable<Gra> Linux   { get; set; }
        public IEnumerable<Gra> Konsola { get; set; }
        public IEnumerable<Gra> Telefon  { get; set; }

        //Define properties for Books
        public IEnumerable<Ksiazka> Horrory { get; set; }
        public IEnumerable<Ksiazka> Fantastyka { get; set; }

        //Define properties for Random
        public IEnumerable<Gra> GryLosowe { get; set; }
        public IEnumerable<Ksiazka> KsiazkaLosowe { get; set; }
    }
}