using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many buses do you want?");
            int numberOfBus = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hatchbackes do you want?");
            int numberOfHatchback = int.Parse(Console.ReadLine());
            Console.WriteLine("What brand do you want?");
            string brand = Console.ReadLine();

            List<Car> cars = new List<Car>();

            Brand brand1 = Convert(brand);
            Factory factory = CreateFactory(brand1);

            for (int i = 1; i <= numberOfBus; i++)
            {
                cars.Add(factory.CreateBus(12, "Golqm", "XYZ1234"));
            }

            for (int i = 1; i <= numberOfHatchback; i++)
            {
                cars.Add(factory.CreateHatchback(4, "Corsa", "XYZ9876"));
            }

            foreach (Car car in cars)
            {
                car.PrintResults();
            }

        }

        static Brand Convert(string brand)
        {
            if (brand == "Merzedes")
            {
                return Brand.Merzedes;
            }
            else if (brand == "Opel")
            {
                return Brand.Opel;
            }
            else
            {
                return Brand.Merzedes;
            }

        }

        static Factory CreateFactory(Brand brand)
        {

            if (brand == Brand.Merzedes)
            {
                return new MerzedesFactory();
            }
            else if (brand == Brand.Opel)
            {
                return new OpelFactory();
            }
            else
            {
                return new MerzedesFactory();
            }
            
        }
    }
}
