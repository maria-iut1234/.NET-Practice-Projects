using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_1
{
    internal sealed class Door
    {
        private string opening_mode;

        public void setOpeningMode(string opening_mode)
        {
            this.opening_mode=opening_mode;
        }

        public string getOpeningMode()
        {
            return this.opening_mode;
        }
    }
}
