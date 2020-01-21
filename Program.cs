using Microsoft.EntityFrameworkCore;
using MySQLDemo.DataModels;
using System;
using System.Linq;
using System.Text;

namespace MySQLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new demoprojectdatabaseContext())
            {
                var studentCourses = ctx.Studentcourses
                    .Include(sc => sc.Student)
                    .Include(sc => sc.Course)
                    .OrderByDescending(sc => sc.DateEnrolled);

                foreach (var sc in studentCourses)
                {
                    Console.WriteLine("{0} {1} enrolled into {2} on {3}", sc.Student.Name, sc.Student.Lastname, sc.Course.Name, sc.DateEnrolled.Date.ToShortDateString());
                }

                Console.ReadKey();
            }
        }
    }
}
