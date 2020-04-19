using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Hatchback : Car
    {
        int numberOfSeats;
        public Hatchback(int numberOfSeats, string model, string regNumber) : base (model, regNumber)
        {
            this.numberOfSeats = numberOfSeats;
        }

        //public override void PrintResults()
        //{
        //    Console.WriteLine("The hatchback model is: ");
        //    base.PrintResults();
        //}

        public override string ToString()
        {
            return base.ToString() + $"The hatchback number of seats is: {numberOfSeats}";
        }
    }
}
