using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Labe(object sender, EventArgs e)
        {

        }

        private void show_sum(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox_num1.Text);
            double num2 = Convert.ToDouble(textBox_num2.Text);
            string sum = Convert.ToString(num1 + num2);

            MessageBox.Show("The sum of the two numbers is " + sum);
        }

        private void show_diff(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox_num1.Text);
            double num2 = Convert.ToDouble(textBox_num2.Text);
            string diff = Convert.ToString(num1 - num2);

            MessageBox.Show("The difference of the two numbers is " + diff);
        }
    }
}
