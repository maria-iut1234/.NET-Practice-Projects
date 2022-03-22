using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_2_and_3
{
    internal class Typist:Staff
    {
        private double speed=0.0;

        //Shows Different Types of Inheritance
        public override string whoAmI()
        {
            return "I am a typist - staff.\n";
        }

        //Get Functions for private attributes
        public double getSpeed()
        {
            return this.speed;
        }

        //Set Functions for private attributes
        public void setSpeed(double speed)
        {
            this.speed = speed;
        }

        //Function to display information
        public virtual string displayInformation()
        {
            string info;

            info = "Code: " + this.code + "\n";
            info += "Name: " + this.name + "\n";
            info += "Type: " + whoAmI() + "\n";
            info += "Speed: " + this.speed.ToString() + "words per minute" + "\n";

            return info;
        }
    }
}
