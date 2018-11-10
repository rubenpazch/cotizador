using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel.Currencies.ViewModels
{
    public class CurrencyDisplayViewModel
    {
        [Display(Name="ID")]
        public int currencyId { get; set; }

        [Display(Name = "Short Name")]
        public string shortName { get; set; }

        [Display(Name = "Large Name")]
        public string largeName { get; set; }

        [Display(Name = "Country")]
        public string country { get; set; }
    }
}
