using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class MerzedesBus : Bus
    {
        string brand;

        public MerzedesBus(double load, string model, string regNumber) : base(load, model, regNumber)
        {
            this.brand = "Merzedes";
        }

        public override void PrintResults()
        {
            Console.WriteLine("The brand is Merzedes.");
            base.PrintResults();
        }
    }
}
