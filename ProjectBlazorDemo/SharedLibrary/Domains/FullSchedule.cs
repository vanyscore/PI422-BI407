using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Domains
{
    public class FullSchedule
    {
        public string ActiveGroup { get; set; }

        public List<DaySchedule> Days { get; set; }

        public List<Lesson> AllLessons { get; set; }

        public List<LessonSpan> TimeSpans { get; set; }

        public static FullSchedule Default
        {
            get
            {
                return new FullSchedule()
                {
                    AllLessons = new List<Lesson>()
                    {
                        new Lesson()
                        {
                            Number = 2,
                            Cabinet = "247",
                            Professor = "Чеботарев С.С.",
                            Discipline = "Объектно-ориентированное программирование",
                            DayOfWeek = DayOfWeek.Friday,
                            AcademicGroup = "ПИ-223"
                        },
                        new Lesson()
                        {
                            Number = 3,
                            Cabinet = "246",
                            Professor = "Статных А.С.",
                            Discipline = "Базы данных",
                            DayOfWeek = DayOfWeek.Friday,
                            AcademicGroup = "ПИ-223"
                        },
                        new Lesson()
                        {
                            Number = 4,
                            Cabinet = "249",
                            Professor = "Овсяницкая Л.Ю.",
                            Discipline = "Машинное обучение",
                            DayOfWeek = DayOfWeek.Friday,
                            AcademicGroup = "ПИ-223"
                        },
                        
                        new Lesson()
                        {
                            Number = 1,
                            Cabinet = "147",
                            Professor = "Кучина",
                            Discipline = "Экономика",
                            DayOfWeek = DayOfWeek.Monday,
                            AcademicGroup = "ПИ-223"
                        },
                        new Lesson()
                        {
                            Number = 2,
                            Cabinet = "146",
                            Professor = "Кучина",
                            Discipline = "Экономика",
                            DayOfWeek = DayOfWeek.Monday,
                            AcademicGroup = "ПИ-223"
                        },
                        new Lesson()
                        {
                            Number = 3,
                            Cabinet = "149",
                            Professor = "Гисс",
                            Discipline = "Проектирование информационных систем",
                            DayOfWeek = DayOfWeek.Monday,
                            AcademicGroup = "ПИ-223"
                        },
                        new Lesson()
                        {
                            Number = 4,
                            Cabinet = "245",
                            Professor = "Остапенко Н.А.",
                            Discipline = "Python",
                            DayOfWeek = DayOfWeek.Monday,
                            AcademicGroup = "ПИ-223"
                        },

                        new Lesson()
                        {
                            Number = 1,
                            Cabinet = "347",
                            Professor = "Струну",
                            Discipline = "Бух. учёт",
                            DayOfWeek = DayOfWeek.Saturday,
                            AcademicGroup = "ПИ-223"
                        },
                        new Lesson()
                        {
                            Number = 2,
                            Cabinet = "346",
                            Professor = "Статных А.С.",
                            Discipline = "Базы данных",
                            DayOfWeek = DayOfWeek.Saturday,
                            AcademicGroup = "ПИ-223"
                        }
                    },
                    TimeSpans = new List<LessonSpan>()
                    {
                        new LessonSpan()
                        {
                            Start = new TimeSpan(8,30,0),
                            Finish = new TimeSpan(10,05,0)
                        },
                        new LessonSpan()
                        {
                            Start = new TimeSpan(10,15,0),
                            Finish = new TimeSpan(11,50,0),
                        },
                        new LessonSpan()
                        {
                            Start = new TimeSpan(12,00,0),
                            Finish = new TimeSpan(13,35,0)
                        },
                        new LessonSpan()
                        {
                            Start = new TimeSpan(14,15,0),
                            Finish = new TimeSpan(15,50,0)
                        },
                        new LessonSpan()
                        {
                            Start = new TimeSpan(16,00,0),
                            Finish = new TimeSpan(17,35,0)
                        },
                        new LessonSpan()
                        {
                            Start = new TimeSpan(17,55,0),
                            Finish = new TimeSpan(19,30,0)
                        },
                        new LessonSpan()
                        {
                            Start = new TimeSpan(19,40,0),
                            Finish = new TimeSpan(21,15,0)
                        },
                    }
                };
            }
        }

    }
}
