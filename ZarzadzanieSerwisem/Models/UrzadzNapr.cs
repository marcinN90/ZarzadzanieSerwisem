using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class UrzadzNapr
    {
        [Display(Name ="Wpis nr:")]
        public int UrzadzNaprId { get; set; }

        [Display(Name = "Urzadzenie Naprawiane")]
        public int PrzyjeteUrzadzenieId { get; set; }

        [Display(Name = "Data Wpisu")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime UrzadzNaprDataWpisu { get; set; }

        [Display(Name = "Status")]
        public int StatusNaprawyId { get; set; }

        [Display(Name = "Serwisant:")]
        public int SerwisantId { get; set; }
        
        [Display(Name ="Naprawiana Usterka 1:")]
        public int Usterka1Id { get; set; } 

        [Display(Name = "Naprawiana Usterka 2:")]
        public int Usterka2Id { get; set; }

        [Display(Name = "Pozycja 1:")]
        public string UrzadzNaprPozycja1 { get; set; }

        [Display(Name = "Pozycja 2:")]
        public string UrzadzNaprPozycja2 { get; set; }

        [Display(Name = "Pozycja 3:")]
        public string UrzadzNaprPozycja3 { get; set; }

        [Display(Name = "Pozycja 4:")]
        public string UrzadzNaprPozycja4 { get; set; }

        [Display(Name = "Brakująca część 1:")]
        public string UrzadzNaprBrakujacaCzesc1 { get; set; }

        [Display(Name = "Brakująca część 2:")]
        public string UrzadzNaprBrakujacaCzesc2 { get; set; }

        public virtual Usterka Usterka { get; set; }

        public virtual StatusNaprawy StatusNaprawy { get; set; }

        public virtual PrzyjeteUrzadzenie PrzyjeteUrzadzenie { get; set; }

        public virtual Serwisant Serwisant { get; set; }


    }
}