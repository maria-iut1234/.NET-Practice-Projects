using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Teacher
    {
        public int teacher_id;
        public string teacher_name;
        public string teacher_dept;
        public string teacher_sem;
        public double teacher_salary;

        public string get_teacher_info()
        {
            string teacher_info;
            teacher_info = teacher_id.ToString() + "\t" + teacher_name + "\t" + teacher_dept + "\t" + teacher_sem + "\t" + teacher_salary.ToString();
            return teacher_info;
        }
    }
}
