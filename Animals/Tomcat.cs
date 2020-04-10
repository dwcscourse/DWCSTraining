using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string nameOfAnimal, int age) : 
            base (nameOfAnimal, age, "male")
        {
            kindOfAnimal = "Tomcat";    
        }

        public override void ProduceSound()
        {
            base.ProduceSound();
            Console.WriteLine("Give me one million b***h");
        }

        public override void PrintResults()
        {
            base.PrintResults();
        }
    }
}
