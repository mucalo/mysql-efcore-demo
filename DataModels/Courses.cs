using System;
using System.Collections.Generic;

namespace MySQLDemo.DataModels
{
    public partial class Courses
    {
        public Courses()
        {
            Studentcourses = new HashSet<Studentcourses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Studentcourses> Studentcourses { get; set; }
    }
}
