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
    }
}
