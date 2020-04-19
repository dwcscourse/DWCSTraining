using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    class Person
    {
        protected string name;
        protected int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (this.IsValid(value))
                {
                    this.age = value;
                }
                else
                {
                    this.age = 20;
                }

            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.Age = age;
            Console.WriteLine("Person instance created");
        }
       

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello I am {name} and I am {age} years old");
        }
        protected virtual bool IsValid(int age)
        {
            return age > 0;
        }
    }

}
