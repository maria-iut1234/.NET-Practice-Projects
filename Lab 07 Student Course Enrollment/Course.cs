using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_Student_Course_Enrollment
{
    internal class Course
    {
        public string course_name;
        public string course_level;
        public double course_fee;

        public Course(string course_name, string course_level, double course_fee)
        {
            this.course_fee = course_fee;
            this.course_level = course_level;
            this.course_name = course_name;
        }
    }
}
