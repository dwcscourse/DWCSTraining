using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class MerzedesHatchback : Hatchback
    {
        string brand;

        public MerzedesHatchback(int numberOfSeats, string model, string regNumber) : base (numberOfSeats, model, regNumber)
        {
            this.brand = "Merzedes";
        }

        //public override void PrintResults()
        //{
        //    Console.WriteLine("The brand is Merzedes.");
        //    base.PrintResults();
        //}

        public override string ToString()
        {
            return base.ToString() + "The brand is Merzedes.";
        }
    }
}
