using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel.ServiceTypes.ViewModels
{
    public class ServiceTypeDisplayViewModel
    {
        [Required]
        [Display(Name = "Id")]
        public int serviceTypeId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string titleServiceType { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string descriptionServiceType { get; set; }
    }
}
