using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public class Private : Soldier, IPrivate
    {

        private double salary;
        public Private(int id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
        {
            this.salary = salary;
        }

        public double Salary
        {
            get
            {
                return salary;
            }
        }

        public static string rota;

        public override string ToString()
        {
            return base.ToString() + $"Salary: {Salary:f2}";
        }
    }
}
