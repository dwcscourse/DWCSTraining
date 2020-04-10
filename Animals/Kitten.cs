using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string nameOfAnimal, int age) : 
            base (nameOfAnimal, age, "female")
        {
            kindOfAnimal = "Kitten";
        }

        public override void ProduceSound()
        {
            base.ProduceSound();
            Console.WriteLine("Mial");
        }

        public override void PrintResults()
        {
            base.PrintResults();
        }
    }
}
