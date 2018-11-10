using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class Ubigeo
    {
        public int ubigeoId { get; set; }
        public string title { get; set; }
        public string code { get; set; }
        public string label { get; set; }
        public string search { get; set; }
        public int numberChildrens { get; set; }
        public int levelOrder { get; set; }
        public int fatherId { get; set; }

        public override string ToString()
        {
            return "Id: "+ubigeoId+" title: "+ title;
        }

    }
}
