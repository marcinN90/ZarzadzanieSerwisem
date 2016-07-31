using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class PrzyjeteUrzadzenie
    {

        [Display(Name = "Numer Id:")] 
        public int PrzyjeteUrzadzenieId { get; set; }      

        [Display(Name = "Tytuł:")]
        [MaxLength(200)]
        [Required(ErrorMessage ="Pole wymagane: Urządzanie (model, nazwa)!")]
        public string PrzyjeteUrzadzenieTytul { get; set; }

        [Display(Name = "Informacje:")]
        [Required(ErrorMessage = "Pole wymagane: Informacje")]
        [MaxLength(1000)]
        public string PrzyjeteUrzadzenieInformacje { get; set; }

        [Display(Name = "Nazwa Klienta:")]
        [Required(ErrorMessage ="Pole wymagane: Nazwa Klienta")]
        [MaxLength(1000)]
        public string PrzyjeteUrzadzenieNazwaKlienta { get; set; }

        [Display(Name = "Tel. kontaktowy:")]
        [Required(ErrorMessage = "Pole wymagane: Tel. Kontaktowy")]
        [MaxLength(500)]
        public string PrzyjeteUrzadzenieTelKontaktowy { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Pole wymagane: Tel. Kontaktowy")]
        [MaxLength(500)]
        public string PrzyjeteUrzadzenieEmail { get; set; }

        [Display(Name = "Data przyjęcia:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime PrzyjeteUrzadzenieDataPrzyjecia { get; set; }

        [Display(Name = "Przyjete przez:")]
        public int MagazynierId { get; set; }

        [Display(Name = "Status Magazynowy:")]
        public int StatusMagazynowyId { get; set; }
          
        [Display(Name = "StatusNaprawy")]
        public int StatusNaprawyId { get; set; } 

        [Display(Name = "Wycena [zł]")] 
        public double PrzyjeteUrzadzenieWycena { get; set; }        

        public int SerwisantId { get; set; }



        public virtual StatusNaprawy StatusNaprawy { get; set; }

        public virtual StatusMagazynowy StatusMagazynowy { get; set; }

        public virtual Serwisant Serwisant { get; set; }

        public virtual Magazynier Magazynier { get; set; }

     

    }
}