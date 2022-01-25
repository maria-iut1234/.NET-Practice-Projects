using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades_App
{
    public partial class GradesApp : Form
    {
        public GradesApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( text_name.Text != "" &&
                text_id.Text != "" &&
                text_sem.Text != "" &&
                text_attendance.Text != "" &&
                text_mid.Text != "" &&
                text_final.Text != "" &&
                text_quizI.Text != "" &&
                text_quizII.Text != "" &&
                text_quizIII.Text != "" &&
                text_quizIV.Text != "")    
            {
                double attendance = Convert.ToDouble(text_attendance.Text);
                attendance = Math.Round((attendance / 28) * 30, MidpointRounding.AwayFromZero);
                label_attendance.Text = Convert.ToString(attendance) + "/30";

                label_mid.Text = text_mid.Text + "/75";

                double[] quiz_arr = new double[4] {Convert.ToDouble(text_quizI.Text), Convert.ToDouble(text_quizII.Text),
                                                Convert.ToDouble(text_quizIII.Text), Convert.ToDouble(text_quizIV.Text)};
                Array.Sort(quiz_arr);
                double quiz_sum = quiz_arr[1] + quiz_arr[2] + quiz_arr[3];
                label_quiz.Text = Convert.ToString(quiz_sum) + "/45";

                label_final.Text = text_final.Text + "/150";

                double total = attendance + Convert.ToDouble(text_mid.Text) + quiz_sum + Convert.ToDouble(text_final.Text);
                label_total.Text = Convert.ToString(total) + "/300";

                string grade = null;
                double percent = (total / 300) * 100;
                if (percent >= 80) grade = "A+";
                else if (percent < 80 && percent >= 75) grade = "A";
                else if (percent < 75 && percent >= 70) grade = "A-";
                else if (percent < 70 && percent >= 65) grade = "B+";
                else if (percent < 65 && percent >= 60) grade = "B";
                else if (percent < 60 && percent >= 55) grade = "B-";
                else if (percent < 55 && percent >= 50) grade = "C+";
                else if (percent < 50 && percent >= 45) grade = "C";
                else if (percent < 45 && percent >= 40) grade = "D";
                else if (percent < 40) grade = "F";

                label_grade.Text = grade;

                percent = Math.Round(percent, MidpointRounding.AwayFromZero);
                label_result.Text = text_name.Text + " obtained " + Convert.ToString(percent) + "% marks.";
            }
            else
            {
                MessageBox.Show("Error: Input Field Empty!");
            }
            

        }
    }
}
