using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rgik.Models
{
    public class PublikacjaKsiazki
    {
        public int PublikacjaKsiazkiId { get; set; }
        public int KsiazkaId { get; set; }
        public int GatunekId { get; set; }
        public DateTime DataPublikacji { get; set; }

        [Range(1, 10)]
        public float OcenaPublikacji { get; set; }
        public ICollection<string> Komentarze { get; set; }
    }
}