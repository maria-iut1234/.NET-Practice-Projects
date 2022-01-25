using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaveStudent(object sender, EventArgs e)
        {
            int student_id = Convert.ToInt32(text_studentID.Text);
            string student_name = text_std_name.Text;
            string student_dept = text_std_dep.Text;
            string student_sem = text_std_sem.Text;

            Student dummy_std = new Student();
            dummy_std.set_std_ID(student_id);
            dummy_std.set_std_name(student_name);
            dummy_std.set_std_dept(student_dept);
            dummy_std.set_std_sem(student_sem);

            students.Add(dummy_std);

            listBox_std.Items.Clear();

            listBox_std.Items.Add(dummy_std.get_student_info());

            MessageBox.Show("Student has been added successfully!");

        }

        private void ClearStudent(object sender, EventArgs e)
        {
            text_studentID.Text = String.Empty;
            text_std_name.Text = String.Empty;
            text_std_dep.Text = String.Empty;
            text_std_sem.Text = String.Empty;

            MessageBox.Show("Cleared Successfully!");
        }

        private void ShowStudentInfo(object sender, EventArgs e)
        {
            // listBox_std.Items.Clear();

            // for(int i=0; i<students.Count; i++)
            // {
            //    listBox_std.Items.Add(students[i].get_student_info());
            // }
        }

        private void SaveTeacher(object sender, EventArgs e)
        {
            int teacher_id = Convert.ToInt32(text_tchID.Text);
            string teacher_name = text_tch_name.Text;
            string teacher_dept = text_tch_dep.Text;
            string teacher_sem = text_tch_sem.Text;
            double teacher_sal = Convert.ToDouble(text_tch_salary.Text);

            Teacher dummy_tch = new Teacher();
            dummy_tch.teacher_id = teacher_id;
            dummy_tch.teacher_name = teacher_name;
            dummy_tch.teacher_dept = teacher_dept;
            dummy_tch.teacher_sem = teacher_sem;
            dummy_tch.teacher_salary = teacher_sal;

            teachers.Add(dummy_tch);

            listBox_tch.Items.Clear();

            listBox_tch.Items.Add(dummy_tch.get_teacher_info());
         
            MessageBox.Show("Teacher has been added successfully!");
        }

        private void ClearTeacher(object sender, EventArgs e)
        {
            text_tchID.Text = String.Empty;
            text_tch_name.Text = String.Empty;
            text_tch_dep.Text = String.Empty;
            text_tch_sem.Text = String.Empty;
            text_tch_salary.Text = String.Empty;

            MessageBox.Show("Cleared Successfully!");
        }

        private void ShowTeacherInfo(object sender, EventArgs e)
        {
           // listBox_tch.Items.Clear();

           // for (int i = 0; i < teachers.Count; i++)
           // {
           //     listBox_tch.Items.Add(teachers[i].get_teacher_info());
           // }
        }
    }
}
