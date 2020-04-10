using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class AnimalsProducingSounds : Animal
    {
        public AnimalsProducingSounds(string kindOfAnimal, string nameOfAnimal, int age, string gender) : 
            base (kindOfAnimal, nameOfAnimal, age, gender)
        {
        }

        public virtual void ProduceSound()
        { 
        }

        public override void PrintResults()
        {
            base.PrintResults();
        }
    }
}
