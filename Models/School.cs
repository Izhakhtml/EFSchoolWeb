using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSchoolWeb.Models
{
    public class School1
    {
        public int Id { get; set; }
        public string NameOfSchool { get; set; }
        public string Street { get; set; }
        public bool IfState { get; set; }
        public int NumberOfStudents { get; set; }
    }
}