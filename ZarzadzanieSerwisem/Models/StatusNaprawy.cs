using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class StatusNaprawy
    {
        [Display(Name = "Id:")]
        public int StatusNaprawyId { get; set; }

        [Display(Name = "Status Naprawy")]
        public string StatusNaprawyNazwa { get; set; }

        }
}