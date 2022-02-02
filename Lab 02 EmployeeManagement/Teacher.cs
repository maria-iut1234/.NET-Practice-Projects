using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Teacher
    {
        private int teacher_id;
        private string teacher_name;
        private string teacher_dept;
        private string teacher_sem;
        private double teacher_salary;

        public void setTeacherID(int id)
        {
            this.teacher_id = id;
        }

        public void setTeacherName(string name)
        {
            this.teacher_name = name;
        }

        public void setTeacherDept(string dept)
        {
            this.teacher_dept = dept;
        }

        public void setTeacherSem(string sem)
        {
            this.teacher_sem = sem;
        }

        public void setTeacherSalary(double sal)
        {
            this.teacher_salary = sal;
        }

        public string get_teacher_info()
        {
            string teacher_info;
            teacher_info = teacher_id.ToString() + "\t" + teacher_name + "\t" + teacher_dept + "\t" + teacher_sem + "\t" + "Tk." + teacher_salary.ToString();
            return teacher_info;
        }
    }
}
