using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public class Spy : Private
    {
        private int codeNumber;
        public int CodeNumber
        {
            get 
            {
                return codeNumber;
            }
        }
        public Spy(int id, string firstName, string lastName, double salary, int codeNumber) : base(id, firstName, lastName, salary)
        {
            this.codeNumber = codeNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCode number: {codeNumber}";
        }

    }
}
