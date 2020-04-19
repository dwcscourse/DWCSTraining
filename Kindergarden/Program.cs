using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Tsveti", 36);           
            Person p2 = new Child("Ani", 12, "TU");
            Child c1 = new Child("Neli", 13, "SU");

            p2.SayHello();
            c1.SayHello();
        }
    }
}
