using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernSchoolNeli
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
            return lessonTime.startingHour >= this.startingHour && lessonTime.endHour <= this.endHour;
        }
    }

}
