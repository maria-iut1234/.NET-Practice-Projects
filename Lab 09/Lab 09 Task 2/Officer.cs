using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_2_and_3
{
    internal class Officer:Staff
    {
        private string grade=null;

        //Shows Different Types of Inheritance
        public override string whoAmI()
        {
            return "I am a officer - staff.\n";
        }

        //Get Functions for private attributes
        public string getGrade()
        {
            return this.grade;
        }

        //Set Functions for private attributes
        public void setGrade(string grade)
        {
            this.grade = grade;
        }

        //Function to display information
        public virtual string displayInformation()
        {
            string info;

            info = "Code: " + this.code + "\n";
            info += "Name: " + this.name + "\n";
            info += "Type: " + whoAmI() + "\n";
            info += "Grade: " + this.grade + "\n";

            return info;
        }
    }
}
