using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_Student_Course_Enrollment
{
    internal class Professional:Participant
    {
        public override double CalcCourseFees(double course_fees)
        {
            return 0.1*course_fees+course_fees;
        }
    }
}
