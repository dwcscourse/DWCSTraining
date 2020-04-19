using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    class Child : Person
    {
        string schoolName;
        public Child(string name, int age, string schoolName) : base(name,age)
        {
            this.schoolName = schoolName;
            Console.WriteLine("Child instance created");
            Console.WriteLine(schoolName);
            Console.WriteLine(this.name);
        }

        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine($"And my school is {schoolName}");
        }

        protected override bool IsValid(int age)
        {
            return base.IsValid(age) && age <= 16;
        }
        public void SaySchool()
        {
            Console.WriteLine(schoolName);
        }
    }
}
