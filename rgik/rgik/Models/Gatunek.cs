using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rgik.Models
{
    public class Gatunek
    {
        public int GatunekId { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwe Gatunku")]
        [StringLength(100)]
        public string NazwaGatunku { get; set; }

        public string NazwaPlikuObrazkaGatunku { get; set; }

        public virtual  ICollection<Gra> Gry { get; set; }
        public virtual ICollection<Ksiazka> Ksiazka { get; set; }
    }
}