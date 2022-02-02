using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Student
    {
        private int student_id;
        private string student_name;
        private string student_dept;
        private string student_sem;

        public void set_std_ID(int student_id)
        {
            this.student_id = student_id;
        }

        public void set_std_name(string student_name)
        {
            this.student_name = student_name;
        }

        public void set_std_dept(string student_dept)
        {
            this.student_dept = student_dept;
        }

        public void set_std_sem(string student_sem)
        {
            this.student_sem = student_sem;
        }

        public string get_student_info()
        {
            string student_info;
            student_info = student_id.ToString() + "\t" + student_name + "\t" + student_dept + "\t" + student_sem;
            return student_info;
        }

        public Student()
        {

        }
    }
}
