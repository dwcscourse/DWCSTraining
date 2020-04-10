using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string kindOfAnimal;
        public string nameOfAnimal;
        public int age;
        public string gender;

        public Animal(string kindOfAnimal, string nameOfAnimal, int age, string gender)
        {
            this.kindOfAnimal = kindOfAnimal;
            this.nameOfAnimal = nameOfAnimal;
            this.age = age;
            this.gender = gender;
        }

        public virtual void PrintResults()
        {
            Console.WriteLine(kindOfAnimal);
            Console.WriteLine("{0} {1} {2}", nameOfAnimal, age, gender);
        }
    }
}
