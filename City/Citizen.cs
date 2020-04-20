using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    public class Citizen : Habitant
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string ID) : base (ID)
        {
            this.name = name;
            this.age = age;
        }
    }
}
