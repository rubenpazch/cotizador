using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.EntityModel
{
    public class State
    {
        public int stateId { get; set; }
        public string nameState { get; set; }

        public State(int stateId, string nameState)
        {
            this.stateId = stateId;
            this.nameState = nameState;
        }
    }
}
