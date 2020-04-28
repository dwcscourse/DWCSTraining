using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    public class Robot : Habitant
    {
        private string model;

        public Robot(string model, string ID) : base (ID)
        {
            this.model = model;    
        }
    }
}
