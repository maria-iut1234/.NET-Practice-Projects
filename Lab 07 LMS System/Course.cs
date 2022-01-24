using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_LMS_System
{
    internal class Course
    {
        protected string course_code;
        protected string course_type;
        protected string course_title;
        protected string semester;

        //Getters
        public string getCourseCode()
        {
            return this.course_code;
        }

        //For listbox
        public string getCourseInfo()
        {
            string info;
            info = this.course_code + "\t" + this.course_type + "\t" + this.course_title + "\t" + this.semester + "\n";
            return info;
        }

        //Setter (Polymorphism)
        public virtual void setCourseSemester()
        {
            this.course_type=null;
        }

        //Constructor
        public Course(string course_code, string course_type, string course_title)
        {
            this.course_code = course_code;
            this.course_type = course_type;
            this.course_title = course_title;
            setCourseSemester();
        }
    }
}
