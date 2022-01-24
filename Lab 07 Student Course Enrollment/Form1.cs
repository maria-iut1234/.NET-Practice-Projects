using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_Student_Course_Enrollment
{
    public partial class Form1 : Form
    {
        List<Course> courses = new List<Course>();
        List<Participant> users = new List<Participant>();
        public Form1()
        {
            InitializeComponent();
        }

        public string Level(bool r_beginner, bool r_intermediate, bool r_advanced)
        {
            if (r_beginner == true)
            {
                return "Beginner";
            }
            else if (r_intermediate == true)
            {
                return "Intermediate";
            }
            else if (r_advanced == true)
            {
                return "Advanced";
            }
            else
            {
                return null;
            }
        }

        private void AddParticipant(object sender, EventArgs e)
        {
            if(textBox_participant_name.Text=="" || textBox_registration_num.Text=="" || textBox_contact_num.Text=="" || textBox_email.Text=="")
            {
                MessageBox.Show("Error: Input field can not be empty!");
            }
            else
            {
                string name = textBox_participant_name.Text;
                string registration_num = textBox_registration_num.Text;
                string contact_num = textBox_contact_num.Text;
                string email = textBox_email.Text;

                comboBox_student.Items.Add(name);
                comboBox_show_student.Items.Add(name);

                bool r_beginner = radioButton_level_beginner.Checked;
                bool r_intermediate = radioButton_level_intermediate.Checked;
                bool r_advanced = radioButton_level_advanced.Checked;
                bool r_student = radioButton_type_student.Checked;
                bool r_professional = radioButton_type_professional.Checked;

                Participant dummy_user = new Participant(name, registration_num, contact_num, email, Level(r_beginner, r_intermediate, r_advanced));
                users.Add(dummy_user);

                MessageBox.Show("Participant Added Successfully");
            }
            
        }

        private void AddCourse(object sender, EventArgs e)
        {
            if(textBox_course_name.Text=="" || textBox_course_fee.Text=="")
            {
                MessageBox.Show("Error: Input field can not be empty");
            }
            else
            {
                bool r_beginner = radioButton_course_beginner.Checked;
                bool r_intermediate = radioButton_course_intermediate.Checked;
                bool r_advanced = radioButton_course_advanced.Checked;

                string course_name = textBox_course_name.Text;
                string course_level = Level(r_beginner, r_intermediate, r_advanced);
                double course_fee = Convert.ToDouble(textBox_course_fee.Text);

                comboBox_course.Items.Add(course_name);

                Course dummy_course = new Course(course_name, course_level, course_fee);
                courses.Add(dummy_course);

                MessageBox.Show("Course has been added successfully");
            }
        }

        private void PayAndEnroll(object sender, EventArgs e)
        {
            string enroll_student = comboBox_student.Text;
            string enroll_course = comboBox_course.Text;
            string enroll_date = dateTimePicker_enrollment_date.ToString();
            string enroll_fee=null;

            for(int i=0; i<courses.Count; i++)
            {
                if(courses[i].course_name==enroll_course)
                {
                    enroll_fee = courses[i].course_fee.ToString();

                    for (int j = 0; j < users.Count; j++)
                    {
                        if (users[j].name==enroll_student)
                        {
                            if(users[j].level==courses[j].course_level)
                            {
                                users[j].enrolled_courses = courses[i].course_name;
                                break;
                            }
                        }
                    }

                    MessageBox.Show("Error: User and Course difficulty level does not match!");
                    break;
                }
            }

            label_course_fee.Text = "Course Fee:\nBDT " + enroll_fee;
        }

        private void ShowEnrolledCourses(object sender, EventArgs e)
        {
            string enrolled_student = comboBox_show_student.Text;

            for(int i=0; i<users.Count; i++)
            {
                if(users[i].name==enrolled_student)
                {
                    listBox_courses.Items.Add(users[i].enrolled_courses);

                    for(int j=0; j<courses.Count; j++)
                    {
                        listBox_courses.Items.Add(courses[j].course_name);
                        break;
                    }

                }
            }
            
        }
    }
}
