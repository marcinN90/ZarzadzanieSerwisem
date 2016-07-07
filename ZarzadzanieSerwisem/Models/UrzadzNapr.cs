using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class UrzadzNapr
    {
        // trzeba dodać serwisantId oraz PrzeyjeteUrzadzenieID - poszukac w necie rozwiazania problemu
        [Display(Name = "Status")]
        public string UrzadzNaprStatus { get; set; }

        [Display(Name ="Naprawiana Usterka 1:")]
        public string UrzadzNaprUsterka1 { get; set; } // można się zastanowić czy nie zrobić osobnej tabelki tylko typów usterek

        [Display(Name = "Naprawiana Usterka 2:")]
        public string UrzadzNaprUsterka2 { get; set; } // można się zastanowić czy nie zrobić osobnej tabelki tylko typów usterek

        [Display(Name = "Naprawiony Defekt 1:"]
        public string UrzadzNaprDefekt1 { get; set; }

        [Display(Name = "Naprawiony Defekt 2:"]
        public string UrzadzNaprDefekt2 { get; set; }

        [Display(Name = "Naprawiony Defekt 3:"]
        public string UrzadzNaprDefekt3 { get; set; }

        [Display(Name = "Naprawiony Defekt 4:"]
        public string UrzadzNaprDefekt4 { get; set; }

        //Brakujaca Czesc 1

        //Brakujaca Czesc 2




    }
}