using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Final_RPS
{

    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            //Reading CSV and Adding to list

            var path = @"E:\IUT Classes\2nd Semester\SWE 4202 Object Oriented Concepts I Lab\Lab Final RPS\SWE4201MarkSheet.csv";
            using (var reader = new StreamReader(path))
            {
                var line_dummy = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student dummy = new Student(values[0], values[1], values[2], values[3],
                                                values[4], values[5], values[6], values[7], 
                                                values[8], values[9]);
                    
                    students.Add(dummy);
                }
            }

            //Showing in Listbox

            listBox_show_list.Items.Add("ID" + "\t" + "       Name                          " + "Percentage  " + "Grade" + "\n");

            foreach (Student student in students)
            { 
                student.listboxOutput(listBox_show_list);
            }
        }

        //Searching and Showing info
        private void buttonSearchByID(object sender, EventArgs e)
        {
            if(textBox_search_ID.Text=="")
            {
                MessageBox.Show("Empty Field!");
            }
            else
            {
                try
                {
                    string ID_to_search = textBox_search_ID.Text;
                    bool flag = false;

                    foreach (Student student in students)
                    {
                        if (student.getStudentID() == ID_to_search)
                        {
                            flag = true;
                        }
                    }

                    if(flag==false)
                    {
                        throw new ApplicationException();
                    }

                    var student_Found = from student in students
                                        where student.getStudentID() == ID_to_search
                                        select student;

                    foreach (var student in student_Found)
                    {
                        label_show_search_result.Text = student.getInfo();
                    }
                }
                catch(ApplicationException)
                {
                    MessageBox.Show("Invalid ID");
                }
            }
        }
    }
}
