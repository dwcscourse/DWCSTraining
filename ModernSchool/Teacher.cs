﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernSchool
{
    class Teacher
    {
        private string lesson;
        private List<LessonTime> schedule = new List<LessonTime>();

        public Teacher(string lesson, List<LessonTime> schedule)
        {
            this.lesson = lesson;
            this.schedule = schedule;
        }

        public void Teach(List<Student> students)
        {
            foreach (var student in students)
            {
                foreach (var time in schedule)
                {
                    student.Learn(lesson, time);
                }
                //student.Learn(lesson,schedule[0]);
            }
        }
    }
}