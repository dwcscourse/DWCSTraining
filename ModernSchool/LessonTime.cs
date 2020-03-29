using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernSchool
{
    class LessonTime
    {
        public DateTime startingHour;
        public DateTime endHour;

        public LessonTime(int startingHour, int endHour)
        {
            this.startingHour = new DateTime(DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                startingHour, 0, 0);
            this.endHour = new DateTime(DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                endHour, 0, 0);
        }

        public bool Compare(LessonTime lessonTime)
        {
            bool result = (lessonTime.startingHour >= this.startingHour &&
                lessonTime.startingHour < this.endHour) ||
                (lessonTime.endHour > this.startingHour &&
                lessonTime.endHour <= this.endHour);

            return result;
        }

        public static int CompareLessonTimes(LessonTime l1, LessonTime l2)
        {
            if (l1.startingHour < l2.startingHour)
            {
                return -1;
            }
            else if (l1.startingHour > l2.startingHour)
            {
                return 1;
            }
            return 0;
        }
    }
}