using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class PriceRate
    {
        public int priceRateId { get; set; }
        public Price price { get; set; }
        public Rate rate { get; set; }
        public decimal value { get; set; }

        public PriceRate(int priceRateId, Price price, Rate rate, decimal value)
        {
            this.priceRateId = priceRateId;
            this.price = price;
            this.rate = rate;
            this.value = value;
        }
    }
}
