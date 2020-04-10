using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        public enum TypeOfAnimal
        {
            Dog,
            Frog,
            Cat,
            Kitten,
            Tomcat
        }

        static void Main(string[] args)
        {
            string kindOfAnimal = "";           

            string[] supportedAnimals = new string[] { "Dog" ,  "Frog", "Cat", "Kitten", "Tomcat"};
            List<AnimalsProducingSounds> allAnimals = new List<AnimalsProducingSounds>();

            while (true)
            {
                Console.WriteLine("Enter kind of animal (Dog, Frog, Cat, Kitten or Tomcat) to create an animal or \"Beast!\" for exit");
                kindOfAnimal = Console.ReadLine();

                if (kindOfAnimal.Equals("Beast!"))
                {
                    break;
                }

                if (!supportedAnimals.Contains(kindOfAnimal))
                {
                    throw new Exception("Invalid input!");
                }

                Console.WriteLine($"Enter name, age and gender of the {kindOfAnimal}");
                string phrase = Console.ReadLine();
                string[] words = phrase.Split(',').Select(a => a.Trim()).ToArray();
                int expectedLength = 0;

                if (kindOfAnimal == "Dog" || kindOfAnimal == "Frog" || kindOfAnimal == "Cat")
                {
                    expectedLength = 3;                                                                           
                }
                else 
                {
                    expectedLength = 2;                 
                }

                if (words.Length < expectedLength)
                {
                    throw new Exception("Invalid input!");
                }

                string name = words[0];
                int age = int.Parse(words[1]);
                string gender = "";

                if (expectedLength == 3)
                {
                    gender = words[2];
                }

                if (name == "" || name == " " || age < 0 || (expectedLength ==3 && gender != "female" && gender != "male"))
                {
                    throw new Exception("Invalid input!");
                }

                AnimalsProducingSounds animal = null;
                switch (kindOfAnimal)
                {
                    case "Dog":                       
                        animal = new Dog(name, age, gender);
                        break;
                    case "Frog":
                        animal = new Frog(name, age, gender);    
                        break;
                    case "Cat":
                        animal = new Cat(name, age, gender);
                        break;
                    case "Kitten":
                        animal = new Kitten(name, age);
                        break;
                    case "Tomcat":
                        animal = new Tomcat(name, age);
                        break;
                }
                allAnimals.Add(animal);
            }

            foreach (var animal in allAnimals)
            {
                animal.PrintResults();
                animal.ProduceSound();
            }
        }
    }
}
