using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rgik.Models
{
    public class Ksiazka
    {
        public int KsiazkaId { get; set; }
        public int GatunekId { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwe ksiazki")]
        [StringLength(100)]
        public string NazwaKsiazki { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwe producenta")]
        [StringLength(100)]
        public string Producent { get; set; }
        public string Wydawca { get; set; }
        public string WydawcaPL { get; set; }

        [Required(ErrorMessage = "Wprowadz date wydania")]
        public DateTime DataWydania { get; set; }
        public DateTime DataWydaniaWPolsce { get; set; }

        [Range(1, 10)]
        public float Ocena { get; set; }

        public string NazwaPlikuObrazka { get; set; }

        [Required(ErrorMessage = "Wprowadz opis")]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Wprowadz opis skrocony")]
        [StringLength(100)]
        public string OpisSkrocony { get; set; }

        public WadyIZalety WadyIZalety { get; set; }

        public virtual Gatunek Gatunek { get; set; }
    }

    public struct WadyIZalety
    {
        private ICollection<string> Plusy { get; set; }
        private ICollection<string> Minusy { get; set; }

        public WadyIZalety(ICollection<string> plusy, ICollection<string> minusy)
        {
            Plusy = plusy;
            Minusy = minusy;
        }
    }
}