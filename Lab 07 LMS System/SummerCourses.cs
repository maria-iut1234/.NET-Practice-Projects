using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_LMS_System
{
    internal class SummerCourses:Course
    {
        public override void setCourseSemester()
        {
            semester="Summer";
        }

        public SummerCourses(string course_code, string course_type, string course_title) : base(course_code, course_type, course_title)
        {
            ;
        }
    }
}
