using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_2_and_3
{
    internal class Casual:Typist
    {
        private double daily_wages=0.0;

        //Shows Different Types of Inheritance
        public override string whoAmI()
        {
            return "I am a casual - typist - staff.\n";
        }

        //Get Functions for private attributes
        public double getDailyWages()
        {
            return this.daily_wages;
        }

        //Set Functions for private attributes
        public void setDailyWages(double daily_wages)
        {
            this.daily_wages = daily_wages;
        }

        //Function to display information
        public virtual string displayInformation()
        {
            string info;

            info = "Code: " + this.code + "\n";
            info += "Name: " + this.name + "\n";
            info += "Type: " + whoAmI() + "\n";
            info += "Daily Wages: $" + this.daily_wages + "\n";

            return info;
        }
    }
}
