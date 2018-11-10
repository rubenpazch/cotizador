using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class ServiceType
    {
        public int serviceTypeId { get; set; }
        public string titleServiceType { get; set; }
        public string descriptionServiceType { get; set; }

        public ServiceType(int serviceTypeId, string titleServiceType, string descriptionServiceType)
        {
            this.serviceTypeId = serviceTypeId;
            this.titleServiceType = titleServiceType;
            this.descriptionServiceType = descriptionServiceType;
        }

        public override string ToString()
        {
            return "Id: " + serviceTypeId + " Subtype: " + titleServiceType + " Descripcion: " + descriptionServiceType;
        }
    }
}
