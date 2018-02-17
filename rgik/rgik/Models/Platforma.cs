using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rgik.Models
{
    public class Platforma
    {
        public int PlatformaId { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwe platformy")]
        [StringLength(100)]
        public string NazwaPlatformy { get; set; }

        public virtual ICollection<Gra> Gry { get; set; }
    }
}