using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class Service 
    {
        public int serviceId { get; set; }
        public string titleService { get; set; }
        public string descriptionService { get; set; }
        public ServiceType serviceType { get; set; }

        public Service(int serviceId, string titleService, string descriptionService, ServiceType serviceType)
        {
            this.serviceId = serviceId;
            this.titleService = titleService;
            this.descriptionService = descriptionService;
            this.serviceType = serviceType;
        }

        public override string ToString()
        {
            return "Id : "+serviceId+" , Title : "+ titleService+ " Descripcion : "+ descriptionService ; 
        }

    }
}
