using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : AnimalsProducingSounds
    {
        public Dog(string nameOfAnimal, int age, string gender) : 
            base ("Dog", nameOfAnimal, age, gender)
        {
        }

        public override void ProduceSound()
        {
            base.ProduceSound();
            Console.WriteLine("BauBau");
        }

        public override void PrintResults()
        {
            base.PrintResults();
        }
    }
}
