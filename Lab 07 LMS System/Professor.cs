using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_LMS_System
{
    internal class Professor:Teacher
    {
        private List<Course> theory_courses = new List<Course>();
        private static double theory_credit=3.0;

        //Accessing course list
        public void AddCourse(Course dummy_course)
        {
            this.theory_courses.Add(dummy_course);
        }

        //Getter for List
        public List<Course> getCourseList()
        {
            return this.theory_courses;
        }

        //Calculate Total Credits
        public double CalcCredit()
        {
            return theory_credit * theory_courses.Count;
        }

        //Set Teacher Type (Polymorphism)
        public override void setTeacherType()
        {
            this.teacher_type = "Professor";
        }

        //Base class constructor call
        public Professor(string teacher_name) : base(teacher_name)
        {
            setTeacherType();
        }
    }
}
