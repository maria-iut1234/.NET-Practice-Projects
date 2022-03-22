using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_2_and_3
{
    internal sealed class Teacher:Staff
    {
        private string subject=null;
        private string publication=null;

        //Shows Different Types of Inheritance
        public override string whoAmI()
        {
            return "I am a teacher - staff.\n";
        }

        //Get Functions for private attributes
        public string getSubject()
        {
            return this.subject;
        }
        public string getPublication()
        {
            return this.publication;
        }

        //Set Functions for private attributes
        public void setSubject(string subject)
        {
            this.subject = subject;
        }

        public void setPublication(string publication)
        {
            this.publication = publication;
        }

        //Function to display information
        public override string displayInformation()
        {
            string info;

            info = "Code: " + this.code + "\n";
            info += "Name: " + this.name + "\n";
            info += "Type: " + whoAmI() + "\n";
            info += "Subject: " + this.subject + "\n";
            info += "Publication" + this.publication + "\n";

            return info;
        }
    }
}
