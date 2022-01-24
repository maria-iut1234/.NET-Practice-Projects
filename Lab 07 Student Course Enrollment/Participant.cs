using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_Student_Course_Enrollment
{
    public class Participant
    {
        public string name;
        public string registration_num;
        public string contact_num;
        public string email;
        public string level;
        public string enrolled_courses;

        public virtual double CalcCourseFees(double course_fees)
        {
            return course_fees;
        }

        public Participant(string name, string registration_num, string contact_num, string email, string level)
        {
            this.name = name;
            this.registration_num = registration_num;
            this.contact_num = contact_num;
            this.email = email;
            this.level = level;
        }
    }
}
