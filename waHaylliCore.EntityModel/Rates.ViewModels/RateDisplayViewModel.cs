using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace waHaylliCore.EntityModel.Rates.ViewModels
{
    public class RateDisplayViewModel
    {
        [Display(Name= "ID")]    
        public int rateId { get; set; }
        [Display(Name = "Name Rate")]
        public string nameRate { get; set; }

    }
}
