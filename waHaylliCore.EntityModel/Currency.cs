using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class Currency
    {
        public int currencyId { get; set; }
        public string shortName { get; set; }
        public string largeName { get; set; }
        public string country { get; set; }
    }
}
