using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel.Currencies.ViewModels
{
    public class CurrencyEditViewModel
    {
        [Display(Name = "ID")]
        public int currencyId { get; set; }

        [Required]
        [Display(Name = "Short Name")]
        public string shortName { get; set; }

        [Required]
        [Display(Name = "Large Name")]
        public string largeName { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string country { get; set; }
    }
}
