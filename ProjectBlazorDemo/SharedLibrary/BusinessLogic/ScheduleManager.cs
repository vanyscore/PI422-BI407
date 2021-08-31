using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary.Domains;

namespace SharedLibrary.BusinessLogic
{
    public class ScheduleManager
    {
       
        private FullSchedule _schedule;


        public List<DaySchedule> ActiveScheduleByDays
        {
            get
            {
                return _schedule.Days;
            }
        }

        public ScheduleManager()
        {
            _schedule = new FullSchedule();

            // временно возьмём дефолтное расписание
            _schedule.AllLessons = FullSchedule.Default.AllLessons;
        }

        public ScheduleManager(List<Lesson> lessons)
        {
            _schedule = new FullSchedule();
            _schedule.AllLessons = lessons;
        }

        private DateTime MondayInPast()
        {
            var today = DateTime.Today;
            int shift = (int) today.DayOfWeek;
            return today.AddDays(-shift);
        }

        private void AddLessonToDay(IGrouping<DayOfWeek, Lesson> lessonsPack)
        {
            var mondayDate = MondayInPast();

            DayOfWeek dayOfWeek = lessonsPack.Key;
            var day = _schedule.Days.FirstOrDefault(d => d.DayOfWeek == dayOfWeek);
            if (day == null)
            {
                day = new DaySchedule()
                {
                    Date = mondayDate.AddDays((int)dayOfWeek),
                    DayOfWeek = dayOfWeek,
                    Lessons = new List<Lesson>()
                };
                _schedule.Days.Add(day);
            }
            day.Lessons.AddRange(lessonsPack.OrderBy(l=>l.Number).ToList());
        }

        public void FilterLessonsForGroup(string activeGroup)
        {
            _schedule.Days = new List<DaySchedule>();

            var list = _schedule.AllLessons
                .Where(l => l.AcademicGroup == activeGroup) // фильтр по группе
                .Where(l => l.Week == WeekType.Regular)
                .GroupBy(l => l.DayOfWeek) // группировка занятий по дню недели
                .OrderBy(g => g.Key) // сортировка по возрастанию дня недели
                .ToList(); // всё загоняем в список

            list.ForEach(AddLessonToDay);

            _schedule.ActiveGroup = activeGroup;
        }
    }
}
