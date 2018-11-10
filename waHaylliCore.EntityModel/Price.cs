using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class Price
    {
        public int priceId { get; set; }
        public DateTime registration { get; set; }
        public DateTime expiration { get; set; }
        public Service service { get; set; }
        public int totalPax { get; set; }

        public Price(int priceId, DateTime registration, DateTime expiration, Service service, int totalPax)
        {
            this.priceId = priceId;
            this.registration = registration;
            this.expiration = expiration;
            this.service = service;
            this.totalPax = totalPax;
        }
        public override string ToString()
        {
            return "Id: "+ priceId+ " Registration:  "+registration.ToString()+ " Total Pax: "+totalPax+"" + "\n\n" + service+"\n";
        }
    }
}
