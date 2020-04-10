using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class OpelBus :  Bus
    {
        string brand;

        public OpelBus(double load, string model, string regNumber) : base (load, model, regNumber)
        {
            this.brand = "Opel";  
        }

        public override void PrintResults()
        {
            Console.WriteLine("The brand is Opel.");
            base.PrintResults();
        }
    }
}
