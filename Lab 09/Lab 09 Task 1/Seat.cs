using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_1
{
    internal sealed class Seat
    {
        private string comfortabilitiy;

        public void setComfortability(string comfortability)
        {
            this.comfortabilitiy=comfortability;
        }

        public string getComfortability()
        {
            return this.comfortabilitiy;
        }
    }
}
