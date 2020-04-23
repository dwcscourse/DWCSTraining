using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityWithPetsTD
{
    public class Robot : ICitizen
    {
        private string model;

        private string id;
        public string ID
        {
            get
            {
                return id;
            }
        }

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }
    }
}
