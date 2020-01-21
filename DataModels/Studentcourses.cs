using System;
using System.Collections.Generic;

namespace MySQLDemo.DataModels
{
    public partial class Studentcourses
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime DateEnrolled { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Students Student { get; set; }
    }
}
