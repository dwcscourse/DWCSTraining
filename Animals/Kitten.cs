using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        const string gender = "female";
        public Kitten(string nameOfAnimal, int age) : 
            base (nameOfAnimal, age, gender)
        {
            kindOfAnimal = "Kitten";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mial");
        }

        public override void ValidateInput(string nameOfAnimal, int age, string gender)
        {
            base.ValidateInput(nameOfAnimal, age, "female");
        }

        public override void PrintResults()
        {
            base.PrintResults();
        }
    }
}
