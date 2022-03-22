using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab_11_TickTackToe__Odd_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool flag = true;
        int score_Black = 0;
        int score_Blue = 0;

        public void clearButtons()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        public void checkWinner()
        {
            if((button1.BackColor == button2.BackColor && button2.BackColor == button3.BackColor && button1.BackColor != Color.White) ||
                (button4.BackColor == button5.BackColor && button5.BackColor == button6.BackColor && button4.BackColor != Color.White) ||
                (button7.BackColor == button8.BackColor && button8.BackColor == button9.BackColor && button7.BackColor != Color.White) ||
                (button1.BackColor == button4.BackColor && button4.BackColor == button7.BackColor && button7.BackColor != Color.White) ||
                (button2.BackColor == button5.BackColor && button5.BackColor == button8.BackColor && button8.BackColor != Color.White) ||
                (button3.BackColor == button6.BackColor && button6.BackColor == button9.BackColor && button9.BackColor != Color.White) ||
                (button1.BackColor == button5.BackColor && button5.BackColor == button9.BackColor && button9.BackColor != Color.White) ||
                (button3.BackColor == button5.BackColor && button5.BackColor == button7.BackColor && button7.BackColor != Color.White))
            {
                if(flag==false)
                {
                    MessageBox.Show("Black Wins!");
                    score_Black++;
                    label_score_black.Text = "Black: " + score_Black.ToString();
                    clearButtons();
                }
                else if(flag==true)
                {
                    MessageBox.Show("Blue Wins!");
                    score_Blue++;
                    label_score_blue.Text = "Blue: " + score_Blue.ToString();
                    clearButtons();
                }
                else
                {
                    ;
                }
            }
            else if ((button1.BackColor == Color.Black || button1.BackColor == Color.DarkBlue) &&
                (button2.BackColor == Color.Black || button2.BackColor == Color.DarkBlue) &&
                (button3.BackColor == Color.Black || button3.BackColor == Color.DarkBlue) &&
                (button4.BackColor == Color.Black || button4.BackColor == Color.DarkBlue) &&
                (button5.BackColor == Color.Black || button5.BackColor == Color.DarkBlue) &&
                (button6.BackColor == Color.Black || button6.BackColor == Color.DarkBlue) &&
                (button7.BackColor == Color.Black || button7.BackColor == Color.DarkBlue) &&
                (button8.BackColor == Color.Black || button8.BackColor == Color.DarkBlue) &&
                (button9.BackColor == Color.Black || button9.BackColor == Color.DarkBlue))
            {
                MessageBox.Show("Draw!");
                clearButtons();
            }
        }

        public void generalButtonClick(Button dummy_button)
        {
            if(dummy_button.BackColor!=Color.White)
            {
                ;
            }
            else
            {
                if (flag == true)
                {
                    flag = false;
                    label_switch_player.Text = "Blue's turn";
                    dummy_button.BackColor = Color.Black;
                }
                else if (flag == false)
                {
                    flag = true;
                    label_switch_player.Text = "Black's turn";
                    dummy_button.BackColor = Color.DarkBlue;
                }
                else
                {
                    ;
                }
            }
        }

        private void button1Click(object sender, EventArgs e)
        {
            generalButtonClick(button1);

            checkWinner();
        }

        private void button2Click(object sender, EventArgs e)
        {
            generalButtonClick(button2);

            checkWinner();
        }

        private void button3Click(object sender, EventArgs e)
        {
            generalButtonClick(button3);

            checkWinner();
        }

        private void button4Click(object sender, EventArgs e)
        {
            generalButtonClick(button4);

            checkWinner();
        }

        private void button5Click(object sender, EventArgs e)
        {
            generalButtonClick(button5);

            checkWinner();
        }

        private void button6Click(object sender, EventArgs e)
        {
            generalButtonClick(button6);

            checkWinner();
        }

        private void button7Click(object sender, EventArgs e)
        {
            generalButtonClick(button7);

            checkWinner();
        }

        private void button8Click(object sender, EventArgs e)
        {
            generalButtonClick(button8);

            checkWinner();
        }

        private void button9Click(object sender, EventArgs e)
        {
            generalButtonClick(button9);

            checkWinner();
        }
    }
}
