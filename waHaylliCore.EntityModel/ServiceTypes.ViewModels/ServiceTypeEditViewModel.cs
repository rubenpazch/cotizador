using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel.ServiceTypes.ViewModels
{
    public class ServiceTypeEditViewModel
    {
        [Display(Name="ID")]
        public int serviceTypeId { get; set; }

        [Display(Name = "Title")]
        public string titleServiceType { get; set; }

        [Display(Name = "Description")]
        public string descriptionServiceType { get; set; }
    }
}
