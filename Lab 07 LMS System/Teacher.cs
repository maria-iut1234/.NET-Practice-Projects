using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_LMS_System
{
    internal class Teacher
    {
        protected string teacher_name=null;
        protected string teacher_type=null;

        //Getters
        public string getTeacherName()
        {
            return this.teacher_name;
        }

        //Setters (polymorphism used)
        public virtual void setTeacherType()
        {
            this.teacher_type = null;
        }

        //Constructor
        public Teacher(string teacher_name)
        {
            this.teacher_name = teacher_name;
            setTeacherType();
        }
    }
}
