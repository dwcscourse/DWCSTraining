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

        public Student(LessonTime lesson1, LessonTime lesson2)
        {
            this.busyHours.Add(lesson1);
            this.busyHours.Add(lesson2);
        }

        private bool isFree(LessonTime lessonTime)
        {
            foreach (var hour in this.busyHours)
            {
                return !hour.Compare(lessonTime);                
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
    }
}
