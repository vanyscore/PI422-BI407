using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Domains
{
    public class DaySchedule
    {
        public DayOfWeek DayOfWeek { get; set; }

        private static string[] _days =
        {
            "вс", "пн", "вт", "ср", "чт", "пт", "сб"
        };

        public string DayOfWeekRussian
        {
            get
            {
                return _days[(int)Date.DayOfWeek];
            }
        }

        public DateTime Date { get; set; }

        public List<Lesson> Lessons { get; set; }

    }
}
