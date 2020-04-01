using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            // trima studenti i dvama uchiteli  
            //Compare?????
            List<Student> students = new List<Student>(new Student[] { });
            _ = new Student("Pesho", new LessonTime(10, 12), new LessonTime(16, 18));
            _ = new Student("Ivaylo", new LessonTime(9, 11), new LessonTime(13, 15));
            _ = new Student("Michelle", new LessonTime(14, 15), new LessonTime(12, 13));


            List<LessonTime> scheduleRosen = new List<LessonTime>
            {
                new LessonTime(13, 15)
            };

            List<LessonTime> scheduleEmil = new List<LessonTime>
            {
                new LessonTime(10, 12)
            };

            Teacher Rosen = new Teacher("Programming", scheduleRosen);
            Teacher Emil = new Teacher("Geography", scheduleEmil);

           

         
        }
    }
}
