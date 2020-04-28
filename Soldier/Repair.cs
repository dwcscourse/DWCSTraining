using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public class Repair
    {
        private string name;
        private int hoursWorked;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int HoursWorked
        {
            get
            {
                return hoursWorked;
            }
        }

        public Repair(string name, int hoursWorked)
        {
            this.name = name;
            this.hoursWorked = hoursWorked;
        }
    }
}
