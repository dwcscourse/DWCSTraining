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
            base.ProduceSound();
            Console.WriteLine("MialMial");
        }

        public override void PrintResults()
        {
            base.PrintResults();
        }
    }
}
