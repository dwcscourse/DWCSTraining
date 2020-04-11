using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : AnimalsProducingSounds
    {
        public Cat(string nameOfAnimal, int age, string gender) : 
            base ("Cat", nameOfAnimal, age, gender)
        {           
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MialMial");
        }

        public override void ValidateInput(string nameOfAnimal, int age, string gender)
        {
            base.ValidateInput(nameOfAnimal, age, gender);
        }

        public override void PrintResults()
        {
            base.PrintResults();
        }
    }
}
