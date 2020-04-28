using System;
using System.Collections.Generic;

namespace City
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Habitant> allHabitants = new List<Habitant>();

            while (input != "End")
            {
                allHabitants.Add(CreateHabitant(input));
                input = Console.ReadLine();
            }

            string lastDigitsOfFakeID = Console.ReadLine();
            
            foreach (Habitant habitant in allHabitants)
            {
                if (CheckForFakeID(habitant, lastDigitsOfFakeID))
                {
                    Console.WriteLine(habitant.ID);
                }
            }
        }

        private static Habitant CreateHabitant(string habitant)
        {
            string[] habitantData = habitant.Split(' ');
            if (habitantData.Length == 3)
            {
                return new Citizen(habitantData[0], int.Parse(habitantData[1]), habitantData[2]);
            }
            else if (habitantData.Length == 2)
            {
                return new Robot(habitantData[0], habitantData[1]);
            }
            else
            {
                return new Habitant(habitantData[0]);
            }
        }

        public static bool CheckForFakeID(Habitant habitant, string lastDigitsOfFakeID)
        {
            return habitant.ID.EndsWith(lastDigitsOfFakeID);
        }
    }
}
