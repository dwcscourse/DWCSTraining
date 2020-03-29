using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Person
    {
        private string name;
        private string email;
        private DateTime dateOfHire;

        public string Name 
        { 
            get 
            {
                return name.ToUpper();
            }
        }
        public decimal Salary { get; set; }
               
        public Person(string name, string email, decimal salary, DateTime dateOfHire)
        {
            this.name = name;
            this.email = email;
            this.Salary = salary;
            this.dateOfHire = dateOfHire;
        }

        public void Raise(int percent)
        {
            Salary += Salary * (percent / 100.0m);
        }

        public bool IsVeteran()
        {
            return DateTime.Now.Year - this.dateOfHire.Year >= 2;           
        }

    }
}
