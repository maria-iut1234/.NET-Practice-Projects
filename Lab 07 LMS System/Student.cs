using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_LMS_System
{
    internal class Student
    {
        private string name;
        private string semester;
        private List<Course> enrolled_courses = new List<Course>();

        //setter for adding course
        public void EnrolledCourse(Course dummy)
        {
            enrolled_courses.Add(dummy);
        }

        //getters
        public string getStudentName()
        {
            return this.name;
        }
        public List<Course> getCourseList()
        {
            return this.enrolled_courses;
        }
        public string getStudentSemester()
        {
            return this.semester;
        }

        //Constructor
        public Student(string name, string semester)
        {
            this.name = name;
            this.semester = semester;
        }
        
    }
}
