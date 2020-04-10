using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class OpelHatchback : Hatchback
    {
        string brand;
        public OpelHatchback(int numberOfSeats, string model, string regNumber) : base(numberOfSeats, model, regNumber)
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
