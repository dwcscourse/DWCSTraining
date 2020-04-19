using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Car
    {
        public string model;
        public string regNumber;

        public Car(string model, string regNumber)
        {
            this.model = model;
            this.regNumber = regNumber;
        }

        //public virtual void PrintResults()
        //{
        //    Console.Write($"{model} - {regNumber}\n");
        //}

        public override string ToString()
        {
            return $"{model} - {regNumber}\n";
        }

    }
}
