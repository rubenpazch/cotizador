using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class Activity
    {
        public int idActivity { get; set; }
        public string nameActivity { get; set; }
        public string descripcionActivity { get; set; }

        public Activity(int idActivity, string nameActivity, string descripcionActivity)
        {
            this.idActivity = idActivity;
            this.nameActivity = nameActivity;
            this.descripcionActivity = descripcionActivity;
        }
    }
}
