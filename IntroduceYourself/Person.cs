using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceYourself
{
    class Person
    {
        string name;
        string lastName;
        int age;
        
        public Person(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine($"Hello! My name is {name} {lastName} and i am {age} years old.");
        }
    }

}
