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

        public Currency(int currencyId, string shortName, string largeName, string country)
        {
            this.currencyId = currencyId;
            this.shortName = shortName;
            this.largeName = largeName;
            this.country = country;
        }
    }
}
