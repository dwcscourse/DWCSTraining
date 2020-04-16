using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            string[] numbers = inputNumbers.Split(',');

            string inputURLs = Console.ReadLine();
            string[] urls = inputURLs.Split(',');

            ISmartphone phone = new Nokia();
            
            foreach (string number in numbers)
            {
                Console.WriteLine(phone.Calling(number));
            }

            foreach (string url in urls)
            {
                Console.WriteLine(phone.Browse(url));
            }
        }
    }
}
