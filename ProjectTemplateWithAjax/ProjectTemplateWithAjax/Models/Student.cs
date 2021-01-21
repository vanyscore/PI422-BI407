using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTemplateWithAjax.Models
{
    public enum AcademicGroup
    {
        Pi322, Pi223, Pi124
    }

    public class Student
    {
        public AcademicGroup AcademicGroup { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}