using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_07_LMS_System
{
    public partial class Form1 : Form
    {
        List<Professor> professors = new List<Professor>();
        List<Lecturer> lecturers = new List<Lecturer>();

        List<WinterCourses> winter_courses = new List<WinterCourses>();
        List<SummerCourses> summer_courses = new List<SummerCourses>();

        List<Student> students = new List<Student>();
        
        public Form1()
        {
            InitializeComponent();
        }

        //Adding Teacher
        private void AddTeacher(object sender, EventArgs e)
        {
            if (textBox_teacher_name.Text == "" || comboBox_teacher_type.Text == "")
            {
                MessageBox.Show("Error: Input field can not be empty.");
            }
            else
            {
                string teacher_name = textBox_teacher_name.Text;
                string teacher_type = comboBox_teacher_type.Text;

                if (teacher_type == "Professor")
                {
                    Professor dummy_prof = new Professor(teacher_name);
                    professors.Add(dummy_prof);
                }
                else if(teacher_type=="Lecturer")
                {
                    Lecturer dummy_teacher = new Lecturer(teacher_name);
                    lecturers.Add(dummy_teacher);
                }

                comboBox_teacher.Items.Add(teacher_name);
                MessageBox.Show("Teacher has been added successfully.");
            }
        }

        //Setting Combobox options for course teachers
        private void comboBox_course_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_course_type.Text == "Lab")
            {
                comboBox_course_teacher.Items.Clear();
                foreach (Lecturer lecturer in lecturers)
                {
                    comboBox_course_teacher.Items.Add(lecturer.getTeacherName());
                }
            }
            else if(comboBox_course_type.Text=="Theory")
            {
                comboBox_course_teacher.Items.Clear();
                foreach (Professor prof in professors)
                {
                    comboBox_course_teacher.Items.Add(prof.getTeacherName());
                }
            }
        }

        //Adding Course
        private void AddCourse(object sender, EventArgs e)
        {
            if (textBox_course_code.Text == "" || comboBox_course_type.Text == "" || textBox_course_title.Text == "" || comboBox_course_semester.Text == "" || comboBox_course_teacher.Text == "")
            {
                MessageBox.Show("Error: Input field can not be empty.");
            }
            else
            {
                string course_code = textBox_course_code.Text;
                string course_type = comboBox_course_type.Text;
                string course_title = textBox_course_title.Text;
                string course_semester = comboBox_course_semester.Text;
                string course_teacher = comboBox_course_teacher.Text;

                if (course_semester == "Winter")
                {
                    WinterCourses dummy_wcourse = new WinterCourses(course_code, course_type, course_title);
                    winter_courses.Add(dummy_wcourse);
                    
                    if(course_type=="Lab")
                    {
                        foreach(Lecturer l in lecturers)
                        {
                            if(l.getTeacherName()==course_teacher)
                            {
                                l.AddCourse(dummy_wcourse);
                            }
                        }
                    }
                    else if(course_type=="Theory")
                    {
                        foreach (Professor p in professors)
                        {
                            if (p.getTeacherName() == course_teacher)
                            {
                                p.AddCourse(dummy_wcourse);
                            }
                        }
                    }

                }
                else if(course_semester=="Summer")
                {
                    SummerCourses dummy_scourse = new SummerCourses(course_code, course_type, course_title);
                    summer_courses.Add(dummy_scourse);

                    if (course_type == "Lab")
                    {
                        foreach (Lecturer l in lecturers)
                        {
                            if (l.getTeacherName() == course_teacher)
                            {
                                l.AddCourse(dummy_scourse);
                            }
                        }
                    }
                    else if (course_type == "Theory")
                    {
                        foreach (Professor p in professors)
                        {
                            if (p.getTeacherName() == course_teacher)
                            {
                                p.AddCourse(dummy_scourse);
                            }
                        }
                    }
                }

                MessageBox.Show("Course had been added successfully.");
            }
        }

        //Setting Course options for student
        private void comboBox_student_semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_student_semester.Text == "Winter")
            {
                comboBox_student_course.Items.Clear();
                foreach (WinterCourses wcourse in winter_courses)
                {
                    comboBox_student_course.Items.Add(wcourse.getCourseCode());
                }
            }
            else if(comboBox_student_semester.Text=="Summer")
            {
                comboBox_student_course.Items.Clear();
                foreach (SummerCourses scourse in summer_courses)
                {
                    comboBox_student_course.Items.Add(scourse.getCourseCode()); ;
                }
            }
            else
            {
                ;
            }
        }

        //Adding Student
        private void AddStudent(object sender, EventArgs e)
        {
            if (textBox_student_name.Text == "" || comboBox_student_semester.Text=="" || comboBox_student_course.Text=="")
            {
                MessageBox.Show("Error: Input field can not be empty.");
            }
            else
            {
                string student_name = textBox_student_name.Text;
                string student_course = comboBox_student_course.Text;
                string student_semester = comboBox_student_semester.Text;

                Student dummy = new Student(student_name, student_semester);
                students.Add(dummy);

                foreach(Student s in students)
                {
                    if(s.getStudentName()==student_name)
                    {
                        if(student_semester=="Winter")
                        {
                            foreach(WinterCourses ws in winter_courses)
                            {
                                if(ws.getCourseCode()==student_course)
                                {
                                    s.EnrolledCourse(ws);
                                    break;
                                }
                            }
                        }
                        else if(student_semester=="Summer")
                        {
                            foreach (SummerCourses ss in summer_courses)
                            {
                                if (ss.getCourseCode() == student_course)
                                {
                                    s.EnrolledCourse(ss);
                                    break;
                                }
                            }
                        }

                        break;
                    }
                   
                }

                if(comboBox_student.Items.Contains(student_name))
                {
                    ;
                }
                else
                {
                    comboBox_student.Items.Add(student_name);
                }

                MessageBox.Show("Student has been added successfully");
            }
        }

        //Show Student Info
        private void ShowStudentInfo(object sender, EventArgs e)
        {
            if(comboBox_student.Text=="")
            {
                MessageBox.Show("Error: Input field can not be empty");
            }
            else
            {
                listBox_student.Items.Clear();
                string student = comboBox_student.Text;
                foreach(Student s in students)
                {
                    if(s.getStudentName()==student)
                    {
                        listBox_student.Items.Add("Student Name: " + s.getStudentName());
                        listBox_student.Items.Add("Semester: " + s.getStudentSemester());
                        listBox_student.Items.Add("Courses:");

                        for(int i=0; i<s.getCourseList().Count; i++)
                        {
                            listBox_student.Items.Add(s.getCourseList()[i].getCourseInfo());
                        }

                        break;
                    }
                    else
                    {
                        ;
                    }
                }
            }
        }

        //Show Teacher Info

        private void ShowTeacherInfo_Click(object sender, EventArgs e)
        {
            if (comboBox_teacher.Text == "")
            {
                MessageBox.Show("Error: Input field can not be empty.");
            }
            else
            {
                listBox_teacher.Items.Clear();
                string teacher = comboBox_teacher.Text;
                bool flag = false;

                foreach (Professor p in professors)
                {
                    if (p.getTeacherName() == teacher)
                    {
                        flag = true;
                        listBox_teacher.Items.Add("Teacher Name: " + p.getTeacherName());
                        listBox_teacher.Items.Add("Teacher Type: Professor");
                        listBox_teacher.Items.Add("Total Credit: " + p.CalcCredit().ToString());
                        listBox_teacher.Items.Add("Courses:");

                        for (int i=0; i<p.getCourseList().Count; i++)
                        {
                            listBox_teacher.Items.Add(p.getCourseList()[i].getCourseInfo());
                        }

                        break;
                    }
                    else
                    {
                        ;
                    }
                }

                if (flag == false)
                {
                    foreach (Lecturer l in lecturers)
                    {
                        if (l.getTeacherName() == teacher)
                        {
                            listBox_teacher.Items.Add("Teacher Name: " + l.getTeacherName());
                            listBox_teacher.Items.Add("Teacher Type: Lecturer");
                            listBox_teacher.Items.Add("Total Credit: " + l.CalcCredit().ToString());
                            listBox_teacher.Items.Add("Courses:");

                            for (int i = 0; i < l.getCourseList().Count; i++)
                            {
                                listBox_teacher.Items.Add(l.getCourseList()[i].getCourseInfo());
                            }

                            break;
                        }
                        else
                        {
                            ;
                        }
                    }
                }
                else
                {
                    ;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
