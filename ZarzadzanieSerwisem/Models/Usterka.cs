using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarzadzanieSerwisem.Models
{
    public class Usterka
    {
            
        [Display(Name = "Id:")]
        public int UsterkaId { get; set; }

        [Display(Name = "Status")]
        public string UsterkaNazwa { get; set; }

    }
}
