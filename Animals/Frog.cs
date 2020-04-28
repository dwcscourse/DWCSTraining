using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : AnimalsProducingSounds
    {
        public Frog(string nameOfAnimal, int age, string gender) : 
            base ("Frog", nameOfAnimal, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Frogggg");
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
