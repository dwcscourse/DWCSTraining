using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {            
            Person ivan = new Person("Ivan Ivanov",
                "ivan@gmail.com",
                1000.5m, 
                new DateTime(2015, 1, 30));

            Person asen = new Person("Asen Stefchev",
                "asen@gmail.com",
                1500.5m,
                new DateTime(2011, 12, 11));

            Person nikol = new Person("Nikol Arshinkova",
               "nikol@abv.bg",
               1500.5m,
               new DateTime(2020, 3, 3));

            List<Person> people = new List<Person>();
            people.Add(ivan);
            people.Add(asen);
            people.Add(nikol);

            foreach (var employee in people)
            {
                if (employee.IsVeteran())
                {
                    employee.Raise(10);
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}: {person.Salary:f2}");
            }
        }
    }
}
