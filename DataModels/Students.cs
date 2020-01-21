using System;
using System.Collections.Generic;

namespace MySQLDemo.DataModels
{
    public partial class Students
    {
        public Students()
        {
            Studentcourses = new HashSet<Studentcourses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Studentcourses> Studentcourses { get; set; }
    }
}
