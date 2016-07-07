using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class Serwisant
    {
        [Display(Name = "Id:")]
        public int SerwisantId { get; set; }

        public string SerwisantImie { get; set; }

        public string SerwisantNazwisko { get; set; }

        [NotMapped]
        [Display(Name = "Serwisant:")]
        public string SerwisantPelnaNazwa
        {
            get { return SerwisantImie + " " + SerwisantNazwisko; }
        }
    }
}