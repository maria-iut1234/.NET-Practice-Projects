using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_09_Task_2_and_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showInfo(object sender, EventArgs e)
        {
            //Example of a Staff object

            Staff dummy_staff = new Staff();
            dummy_staff.setCode("1");
            dummy_staff.setName("Abc Def");
            show_label.Text = dummy_staff.displayInformation();

            //Example of a Teacher object

            Teacher dummy_teacher = new Teacher();
            dummy_teacher.setCode("2");
            dummy_teacher.setName("Ghi Jkl");
            dummy_teacher.setSubject("Physics");
            dummy_teacher.setPublication("Paperbacks");
            label1.Text = dummy_teacher.displayInformation();

            //Example of a Typist object

            Typist dummy_typist = new Typist();
            dummy_typist.setCode("3");
            dummy_typist.setName("Mno Pqr");
            dummy_typist.setSpeed(120);
            label2.Text = dummy_typist.displayInformation();

            //Example of an Officer object

            Officer dummy_officer = new Officer();
            dummy_officer.setCode("4");
            dummy_officer.setName("Stu Vwx");
            dummy_officer.setGrade("B");
            label3.Text = dummy_officer.displayInformation();

            //Example of a Regular object

            Regular dummy_regular = new Regular();
            dummy_regular.setCode("5");
            dummy_regular.setName("Yza Bcd");
            dummy_regular.setSpeed(100);
            label6.Text = dummy_regular.displayInformation();

            //Example of a Casual object
            Casual dummy_casual = new Casual();
            dummy_casual.setCode("6");
            dummy_casual.setName("Efg Hik");
            dummy_casual.setDailyWages(175.0);
            label5.Text = dummy_casual.displayInformation();
        }
    }
}
