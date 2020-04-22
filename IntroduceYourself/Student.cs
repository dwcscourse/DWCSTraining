using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceYourself
{
    class Student : Person
    {
        string university;
        string specialty;

        public Student(string name, 
                       string lastName, 
                       int age, 
                       string university, 
                       string specialty) 
            : base(name, lastName, age)
        {
            this.university = university;
            this.specialty = specialty;
        }

        public override void IntroduceYourself()
        {
            base.IntroduceYourself();
            Console.WriteLine($"I study in {university} for a {specialty}");
        }

        public void SaySomething()
        {
            Console.WriteLine("Say something!");
        }
    }
}
