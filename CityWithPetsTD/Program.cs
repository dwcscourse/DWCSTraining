using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityWithPetsTD
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            City city = new City();

            while (input != "End")
            {
                city.CreateInhabitants(input);

                input = Console.ReadLine();
            }

            string lastDigitsOfFakeID = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());

            List<string> fakeIdsList = city.CheckForFakeID(city.Citizens, lastDigitsOfFakeID);
            foreach (string fakeId in fakeIdsList)
            {
                
                Console.WriteLine(fakeId);
               
            }

            List<DateTime> birthdaysList = city.GetBirthdaysForAYear(city.InhabitantsWithBirthday, year);
            foreach (DateTime birtday in birthdaysList)
            {
                Console.WriteLine($"{birtday.ToString("dd/MM/yyyy")}");
            }
        }
    }
}