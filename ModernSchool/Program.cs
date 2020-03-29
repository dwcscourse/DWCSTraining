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

            Console.WriteLine("What's going on?");

            List<LessonTime> scheduleRosen = new List<LessonTime>();
            scheduleRosen.Add(new LessonTime(14, 16));
            scheduleRosen.Add(new LessonTime(9, 11));

            List<LessonTime> scheduleNiki = new List<LessonTime>();
            scheduleNiki.Add(new LessonTime(11, 13));
            scheduleNiki.Add(new LessonTime(8, 10));

            Teacher Rosen = new Teacher("Physics", scheduleRosen);
            Teacher Niki = new Teacher("C#", scheduleNiki);

            Student Ani = new Student("Ani", new LessonTime(14, 16), new LessonTime(8, 10));
            Student Neli = new Student("Neli", new LessonTime(13, 15), new LessonTime(9, 11));
            Student Tsveti = new Student("Tsveti", new LessonTime(12, 14), new LessonTime(10, 12));

            List<Student> students = new List<Student>(new Student[] { Ani, Neli, Tsveti });
                
            Rosen.Teach(students);
            Niki.Teach(students);

            foreach (var student in students)
            {
                student.PrintStudentResult();
            }



            
        }
    }
}
