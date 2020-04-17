using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceYourself
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Bela = new Person("Bella", "Borisova", 6);
            Person Ani = new Student("Ana", "Marinova", 22, "TU", "KSI");
            Student Tsveti = new Student("Tsvety", "Dimitrova", 36, "SU", "Math");

            Bela.IntroduceYourself();
            Ani.IntroduceYourself();
            Tsveti.IntroduceYourself();
            Tsveti.SaySomething();

            List<Person> people = new List<Person>()
            {
                new Person("Bella","Borisova",6),
                new Student("Ana","Marinova",22,"TU","KSI"),
                new Worker("Tsvety","Dimitrova",36,"SU","Math","QA",10000)
            };

            foreach (Person p in people)
            {
                p.IntroduceYourself();
            }

        }
    }
}
