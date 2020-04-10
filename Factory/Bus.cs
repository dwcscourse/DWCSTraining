using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Bus : Car
    {
        double load;
        public Bus(double load, string model, string regNumber) : base (model, regNumber)
        {
            this.load = load;
        }

        public override void PrintResults()
        {
            Console.WriteLine("The bus model is: ");
            base.PrintResults();
        }
    }
}
