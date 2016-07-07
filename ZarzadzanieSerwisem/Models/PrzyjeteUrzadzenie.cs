using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class PrzyjeteUrzadzenie
    {

        [Display(Name = "Id:")] 
        public int PrzyjeteUrzadzenieId { get; set; }      

        [Display(Name = "Urzadzenie:")]
        [MaxLength(200)]
        [Required(ErrorMessage ="Pole wymagane: Urządzanie (model, nazwa)!")]
        public string PrzyjeteUrzadzenieTytul { get; set; }

        [Display(Name = "Informacje:")]
        [Required(ErrorMessage = "Pole wymagane: Informacje")]
        [MaxLength(500)]
        public string PrzyjeteUrzadzenieInformacje { get; set; }

        [Display(Name = "Nazwa Klienta:")]
        [Required(ErrorMessage ="Pole wymagane: Nazwa Klienta")]
        [MaxLength(500)]
        public string PrzyjeteUrzadzenieNazwaKlienta { get; set; }

        [Display(Name = "Data przyjęcia:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime PrzyjeteUrzadzenieDataPrzyjecia { get; set; }

        [Display(Name = "StatusPrzepływu:")]
        public string PrzyjeteUrzadzenieStatusWProcesie { get; set; }
          
        [Display(Name = "StatusNaprawy")]
        public string PrzyjeteUrzadzenieStatusNaprawy { get; set; } 

        [Display(Name = "Wycena Naprawy [zł]")] 
        public double PrzyjeteUrzadzenieWycena { get; set; }

        public int MagazynierId { get; set; }   

        public int SerwisantId { get; set; }

        public virtual Magazynier Magazynier { get; set; }

        public virtual Serwisant Serwisant { get; set; }  

    }
}