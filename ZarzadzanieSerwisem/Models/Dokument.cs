using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class Dokument
    {
        [Display(Name = "Id")]
        public int DokumentId { get; set; }

        [Display(Name = "Tytuł")]
        public string Tytul { get; set; }       
       
        public int KategoriaId { get; set; }       

        public virtual Kategoria Kategoria { get; set; }     
                
    }
}