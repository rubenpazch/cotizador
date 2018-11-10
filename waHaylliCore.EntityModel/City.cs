using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class City
    {
        public int cityId { get; set; }
        public string nameCity { get; set; }

        public County county { get; set; }

        public City(int cityId, string nameCity, County county)
        {
            this.cityId = cityId;
            this.nameCity = nameCity;
            this.county = county;
        }
    }
}
