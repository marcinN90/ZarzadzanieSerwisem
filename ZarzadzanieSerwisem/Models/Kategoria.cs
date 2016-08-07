using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class Kategoria
    {
        [Display(Name="Id")]
        public int KategoriaId { get; set; }

        [Display(Name="Kategoria")]
        public string KategoriaTytul { get; set; }


    }
}