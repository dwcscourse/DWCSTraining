using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernSchool
{
    class Student
    {
        private List<LessonTime> busyHours = new List<LessonTime>();
        private List<string> lessonsAttended = new List<string>();
        private string name; 

        public Student(string name, LessonTime lesson1, LessonTime lesson2)
        {
            this.busyHours.Add(lesson1);
            this.busyHours.Add(lesson2);
            this.name = name;
        }

        private bool isFree(LessonTime lessonTime)
        {
            foreach (var hour in this.busyHours)
            {
                if (hour.Compare(lessonTime))
                {
                    return false;
                }
                //return !hour.Compare(lessonTime);    !!!WRONG!!!          
            }
            return true;
        }

        public void Learn(string lesson, LessonTime lessonTime)
        {
            if(isFree(lessonTime))
            {
                lessonsAttended.Add(lesson);
                busyHours.Add(lessonTime);
            }
        }
        public void PrintStudentResult()
        {
            Console.WriteLine($"The student {name} participates in lectures: ");
            foreach (var lesson in lessonsAttended)
            {
                Console.WriteLine(lesson);
            }

            busyHours.Sort(LessonTime.CompareLessonTimes);

            foreach (var time in busyHours)
            {
                Console.WriteLine($" and he is busy between {time.startingHour} and {time.endHour}");
            }
        }

        
    }
}
