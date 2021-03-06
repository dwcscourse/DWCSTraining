﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static string[] supportedAnimals = new string[] { "Dog", "Frog", "Cat", "Kitten", "Tomcat", "Beast!"};

        static void Main(string[] args)
        {
            string kindOfAnimal = "";           
            List<AnimalsProducingSounds> allAnimals = new List<AnimalsProducingSounds>();

            while (true)
            {
                Console.WriteLine("Enter kind of animal - Dog, Frog, Cat, Kitten or Tomcat or \"Beast!\" for exit");
                kindOfAnimal = Console.ReadLine();               
                ValidateKindOfAnimal(kindOfAnimal);

                int expectedLength = 0;
                if (kindOfAnimal.Equals("Beast!"))
                {
                    break;
                }
                else if (kindOfAnimal == "Dog" || kindOfAnimal == "Frog" || kindOfAnimal == "Cat")
                {
                    Console.WriteLine($"Enter name, age and gender of the {kindOfAnimal}");
                    expectedLength = 3;                                                                           
                }
                else 
                {
                    Console.WriteLine($"Enter name and age of the {kindOfAnimal}");
                    expectedLength = 2;                 
                }

                string phrase = Console.ReadLine();
                string[] words = phrase.Split(',').Select(a => a.Trim()).ToArray();

                CheckExpectedLengthOfArray(words, expectedLength);
               
                string name = words[0];
                int age = int.Parse(words[1]);
                string gender = "";

                if (expectedLength == 3)
                {
                    gender = words[2];
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
                animal.ValidateInput(name, age, gender);
                allAnimals.Add(animal);
            }

            foreach (var animal in allAnimals)
            {
                animal.PrintResults();
                animal.ProduceSound();
            }          
        }

        private static void CheckExpectedLengthOfArray(Array array1, int expectedLength)
        {
            if (array1.Length != expectedLength)
            {
                throw new Exception("Invalid input!");
            }

        }

        public static void ValidateKindOfAnimal(string kindOfAnimal)
        {           
            if (!supportedAnimals.Contains(kindOfAnimal))
            {
                throw new Exception("Invalid input!");
            }
        }
    }
}
