using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class AnimalsProducingSounds : Animal
    {
        public AnimalsProducingSounds(string kindOfAnimal, string nameOfAnimal, int age, string gender) : 
            base (kindOfAnimal, nameOfAnimal, age, gender)
        {
        }

        public abstract void ProduceSound();

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
