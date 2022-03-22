using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final_RPS
{
    sealed internal class Student
    {
        private string student_ID;
        private string name;
        private int attendance ;
        private int quiz_1;
        private int quiz_2;
        private int quiz_3;
        private int quiz_4 ;
        private int mid ;
        private int final ;
        private int viva;
        private double percentage;
        private string grade;
        private int quiz_total;

        public string settingSpace(string name)
        {
            string space = " ";

            for(int i=name.Length; i<30; i++)
            {
                space += " ";
            }

            return space;
        }

        public string getStudentID()
        {
            return this.student_ID;
        }

        public Student(string student_ID, string name, string attendance, string quiz_1, string quiz_2, string quiz_3, string quiz_4, string mid, string final, string viva)
        {
            this.student_ID = student_ID;
            this.name = name;
            this.attendance = Convert.ToInt32(attendance);
            this.quiz_1 = Convert.ToInt32(quiz_1);
            this.quiz_2 = Convert.ToInt32(quiz_2);
            this.quiz_3 = Convert.ToInt32(quiz_3);
            this.quiz_4 = Convert.ToInt32(quiz_4);
            this.mid = Convert.ToInt32(mid);
            this.final = Convert.ToInt32(final);
            this.viva = Convert.ToInt32(viva);

            calcPercentage();
            calcGrade();
        }
        public void calcPercentage()
        {
            double percentage = 0.0;

            double[] quiz= {quiz_1, quiz_2, quiz_3, quiz_4};

            Array.Sort(quiz);

            this.quiz_total = (int)(quiz[3] + quiz[1] + quiz[2]);

            double total = this.attendance + quiz[3] + quiz[1] + quiz[2] + this.mid + this.final + this.viva;
            percentage = (total * 100) / 300;

            this.percentage=percentage;
        }

        public void calcGrade()
        {
            string grade="F";

            if(this.percentage>=80 && this.percentage<=100)
            {
                grade = "A+";
            }
            else if(this.percentage >= 75 && this.percentage <= 79)
            {
                grade = "A";
            }
            else if (this.percentage >= 70 && this.percentage <= 74)
            {
                grade = "A-";
            }
            else if (this.percentage >= 65 && this.percentage <= 69)
            {
                grade = "B+";
            }
            else if (this.percentage >= 60 && this.percentage <= 64)
            {
                grade = "B";
            }
            else if (this.percentage >= 55 && this.percentage <= 59)
            {
                grade = "B-";
            }
            else if (this.percentage >= 50 && this.percentage <= 54)
            {
                grade = "C+";
            }
            else if (this.percentage >= 45 && this.percentage <= 49)
            {
                grade = "C";
            }
            else if (this.percentage >= 40 && this.percentage <= 44)
            {
                grade = "D";
            }
            else if (this.percentage >= 0 && this.percentage <= 39)
            {
                grade = "F";
            }

            this.grade = grade;
        }

        public void listboxOutput(System.Windows.Forms.ListBox listbox)
        {
            listbox.Items.Add(this.student_ID + "\t" + this.name + settingSpace(this.name) + (Convert.ToDecimal(string.Format("{0:F2}", this.percentage))).ToString()+"%" + "\t" + this.grade + "\n");
        }

        public string getInfo()
        {
            return "Attendance: " + attendance.ToString() + "\n" +
                   "Quiz 1: " + quiz_1.ToString() + "\n" +
                   "Quiz 2: " + quiz_2.ToString() + "\n" +
                   "Quiz 3: " + quiz_3.ToString() + "\n" +
                   "Quiz 4: " + quiz_4.ToString() + "\n" +
                   "Quiz Total(Best 3): " + quiz_total.ToString() + "\n" +
                   "Mid: " + mid.ToString() + "\n" +
                   "Final: " + final.ToString() + "\n" +
                   "Viva: " + viva.ToString() + "\n" +
                   "Total (Out of 300): " + (attendance + quiz_total + mid + final + viva).ToString() + "\n" +
                   "Percentage: " + (Convert.ToDecimal(string.Format("{0:F2}", this.percentage))).ToString() + "%" + "\n" +
                   "Grade: " + grade + "\n";
        }
    }
}
