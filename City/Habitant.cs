using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    public class Habitant
    {
        private string id;
        public string ID 
        {
            get
            {
                return id;
            }
        }

        public Habitant(string id)
        {
            this.id = id;
        }

    }
}
