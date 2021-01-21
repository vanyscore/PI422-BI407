using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectTemplateWithAjax.Models;

namespace ProjectTemplateWithAjax.Repository
{
    public class DataManager
    {
        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Firstname = "Илья",
                    Lastname = "Дулепов",
                    AcademicGroup = AcademicGroup.Pi322
                },
                new Student()
                {
                    Firstname = "Иван",
                    Lastname = "Пичугин",
                    AcademicGroup = AcademicGroup.Pi322
                },
                new Student()
                {
                    Firstname = "Михаил",
                    Lastname = "Балашев",
                    AcademicGroup = AcademicGroup.Pi322
                },
                new Student()
                {
                    Firstname = "Кирилл",
                    Lastname = "Климов",
                    AcademicGroup = AcademicGroup.Pi223
                },
                new Student()
                {
                    Firstname = "Александр",
                    Lastname = "Макеенко",
                    AcademicGroup = AcademicGroup.Pi223
                },
                new Student()
                {
                    Firstname = "Алексей",
                    Lastname = "Дубенко",
                    AcademicGroup = AcademicGroup.Pi124
                },
                new Student()
                {
                    Firstname = "Константин",
                    Lastname = "Бикбулатов",
                    AcademicGroup = AcademicGroup.Pi124
                }
            };
        }
    }
}