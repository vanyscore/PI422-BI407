using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Domains
{
    public enum WeekType
    {
        Regular = 0,
        Left = 1,
        Right = 2
    }

    public class Lesson
    {
        public WeekType Week { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int Number { get; set; }
        public string Professor { get; set; }
        public string Discipline { get; set; }
        public string Cabinet { get; set; }
        public string AcademicGroup { get; set; }

        public TimeSpan StartTime
        {
            get
            {
                return FullSchedule.Default.TimeSpans[Number-1].Start;
            }
        }

        public TimeSpan FinishTime
        {
            get
            {
                return FullSchedule.Default.TimeSpans[Number -1].Finish;
            }
        }
    }
}
