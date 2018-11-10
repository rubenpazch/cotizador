using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class Rate
    {
        public int rateId { get; set; }
        public string nameRate { get; set; }
        public Currency currency { get; set; }

        public Rate(int rateId, string nameRate, Currency currency)
        {
            this.rateId = rateId;
            this.nameRate = nameRate;
            this.currency = currency;
        }
    }
}
