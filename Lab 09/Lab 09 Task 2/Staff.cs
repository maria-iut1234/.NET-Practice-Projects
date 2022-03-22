using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_2_and_3
{
    internal class Staff
    {
        protected string code=null;
        protected string name=null;

        //Shows Different Types of Inheritance
        public virtual string whoAmI()
        {
            return "I am a staff.\n";
        }

        //Set Functions for private attributes
        public void setCode(string code)
        {
            this.code = code;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        //Function to display information
        public virtual string displayInformation()
        {
            string info;

            info = "Code: " + this.code + "\n";
            info += "Name: " + this.name + "\n";
            info += "Type: " + whoAmI() + "\n";

            return info;
        }
    }
}
