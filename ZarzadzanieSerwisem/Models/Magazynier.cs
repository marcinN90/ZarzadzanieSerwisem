using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class Magazynier
    {
        [Display(Name = "Id:")]
        public int MagazynierId { get; set; }

        public string MagazynierImie { get; set; }

        public string MagazynierNazwisko { get; set; }

        [NotMapped]
        [Display(Name = "Magazynier:")]
        public string MagazynierPelnaNazwa
        {
            get { return MagazynierImie + " " + MagazynierNazwisko; }
        }
    }
}