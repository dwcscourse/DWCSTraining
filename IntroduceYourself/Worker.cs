using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceYourself
{
    class Worker : Student
    {
        string work;
        decimal salary;


        public Worker(string name,
            string lastName,
            int age,
            string university,
            string specialty,
            string work,
            decimal salary)
            : base(name, lastName, age, university, specialty)
        {
            this.work = work;
            this.salary = salary;
        }

        public override void IntroduceYourself()
        {
            base.IntroduceYourself();
            Console.WriteLine($"And I work as a {work}. I get {salary}$");
        }
    }
}
