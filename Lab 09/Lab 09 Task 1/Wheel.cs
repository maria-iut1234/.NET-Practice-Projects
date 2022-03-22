using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_1
{
    internal sealed class Wheel
    {
        private double radius;
        private double circumference;

        public void setRadius(double radius)
        {
            this.radius=radius;
        }

        public double getCircumference()
        {
            return (2 * Math.PI * this.radius);
        }
    }
}
