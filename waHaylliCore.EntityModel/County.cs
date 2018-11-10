using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class County
    {
        public int cityId { get; set; }
        public string nameCity { get; set; }
        public State state { get; set; }

        public County(int cityId, string nameCity, State state)
        {
            this.cityId = cityId;
            this.nameCity = nameCity;
            this.state = state;
        }
    }
}
