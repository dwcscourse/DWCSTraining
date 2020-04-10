using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfAnimal = "";
            string name = "";   
            int age = 0;
            string gender = "";
            string[] supportedAnimals = new string[] { "Dog" ,  "Frog", "Cat", "Kitten", "Tomcat"};
            List<AnimalsProducingSounds> allAnimals = new List<AnimalsProducingSounds>();

            while (kindOfAnimal != "Beast!")
            {
                Console.WriteLine("Enter kind of animal (Dog, Frog, Cat, Kitten or Tomcat) to create an animal or \"Beast!\" for exit");
                kindOfAnimal = Console.ReadLine();

                if (!supportedAnimals.Contains(kindOfAnimal) && kindOfAnimal != "Beast!")
                {
                    throw new Exception("Invalid input!");
                }

                if (kindOfAnimal.Equals("Beast!")) {
                    break;
                }


                if (kindOfAnimal == "Dog" || kindOfAnimal == "Frog" || kindOfAnimal == "Cat")
                {
                    Console.WriteLine($"Enter name, age and gender of the {kindOfAnimal}");
                    string phrase = Console.ReadLine();
                    string[] words = phrase.Split(',').Select(a => a.Trim()).ToArray();

                    if (words.Length < 2)
                    {
                        throw new Exception("Invalid input!");
                    }

                    if (words.Contains("Beast!"))
                    {
                        break;
                    }

                    name = words[0];
                    age = int.Parse(words[1]);
                    gender = words[2];

                    if (name == "" || name == " " || age < 0 || (gender != "female" && gender != "male"))
                    {
                        throw new Exception("Invalid input!");
                    }
                }
                else if (kindOfAnimal == "Kitten" || kindOfAnimal == "Tomcat")
                {
                    Console.WriteLine($"Enter name and age of the {kindOfAnimal}");
                    string phrase = Console.ReadLine();
                    string[] words = phrase.Split(',').Select(a => a.Trim()).ToArray();

                    if (words.Length < 1)
                    {
                        throw new Exception("Invalid input!");
                    }

                    if (words.Contains("Beast!"))
                    {
                        break;
                    }

                    name = words[0];
                    age = int.Parse(words[1]);

                    if (name == "" || name == " " || age < 0 )
                    {
                        throw new Exception("Invalid input!");
                    }
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
