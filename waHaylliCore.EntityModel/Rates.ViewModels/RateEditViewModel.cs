using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel.Rates.ViewModels
{
    public class RateEditViewModel
    {
        [Display(Name = "ID")]
        public int rateId { get; set; }

        [Required]
        [Display(Name = "Name Rate")]
        [StringLength(75)]
        public string nameRate { get; set; }

    }
}
