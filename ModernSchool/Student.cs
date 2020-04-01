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
        private string v;
        private LessonTime lessonTime1;
        private LessonTime lessonTime2;

        public Student(LessonTime lesson1, LessonTime lesson2)
        {
            this.busyHours.Add(lesson1);
            this.busyHours.Add(lesson2);
        }

        public Student(string v, LessonTime lessonTime1, LessonTime lessonTime2)
        {
            this.v = v;
            this.lessonTime1 = lessonTime1;
            this.lessonTime2 = lessonTime2;
        }

        private bool IsFree(LessonTime lessonTime)
        {
            foreach (var hour in this.busyHours)
            {
                return !hour.Compare(lessonTime);
            }
            return true;
        }
        public void Learn(string lesson, LessonTime lessonTime)
        {
            if (IsFree(lessonTime))
            {
                lessonsAttended.Add(lesson);
                busyHours.Add(lessonTime);
            }
        }

        

    }
}

