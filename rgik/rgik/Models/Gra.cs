using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rgik.Models
{
    public class Gra
    {
        public int GraId { get; set; }
        public int GatunekId { get; set; }
        public int PlatformaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe gry")]
        [StringLength(100)]
        public string NazwaGry { get; set; }


        [Required(ErrorMessage = "Wprowadz nazwe producenta")]
        [StringLength(100)]
        public string Producent { get; set; }
        public string Wydawca { get; set; }
        public string WydawcaPL { get; set; }

        [Required(ErrorMessage = "Wprowadz date wydania")]
        public DateTime DataWydania { get; set; }
        public DateTime DataWydaniaWPolsce { get; set; }

        [Range(1,10)]
        public float Ocena { get; set; }

        public TrybGry TrybGry { get; set; }
        public string NazwaPlikuObrazka { get; set; }


        public Parametry Parametry { get; set; }
        public List<string> Plusy { get; set; }
        public List<string> Minusy { get; set; }

        [Required(ErrorMessage = "Wprowadz opis")]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Wprowadz opis skrocony")]
        [StringLength(100)]
        public string OpisSkrocony { get; set; }
        public int SzacowanaDlugoscGry { get; set; }

        public virtual Gatunek Gatunek { get; set; }

    }

    public enum TrybGry
    {
        SinglePlayer,
        Multiplayer,
        SinglePlayerAndMultiPlayer
    }

    public class Parametry
    {
        public Parametry()
        {

        }
        public Parametry(string procesor,string kartaGraficzna, int ram,int pamiec)
        {
            this.procesor = procesor;
            this.kartaGraficzna = kartaGraficzna;
            this.ram = ram;
            this.pamiec = pamiec;
        }

        public string procesor { get; set; }
        public string kartaGraficzna { get; set; }
        public int ram { get; set; }
        public int pamiec { get; set; }

        public override string ToString()
        {
            return "Wymagania systemowe: " + "Procesor: " + procesor + "\n"
                + "Karta Graficzna: " + kartaGraficzna + "\n"
                + "Ram: " + ram + "\n"
                + "Pamiec " + pamiec + "\n";
        }

    }
}