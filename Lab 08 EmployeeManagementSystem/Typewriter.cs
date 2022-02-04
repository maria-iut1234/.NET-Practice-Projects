using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_EmployeeManagementSystem
{
    sealed internal class Typewriter:Employee
    {
        private static double salary_t = 5000.0;
        private static int employeeID = 10;
        public override void setDesignation(string x)
        {
            this.designation = "Typewriter";
        }

        public string getSalary()
        {
            return Typewriter.salary_t.ToString();
        }

        public void setEmployeeID()
        {
            Typewriter.employeeID++;
        }
        public int getEmployeeID()
        {
            return Typewriter.employeeID;
        }

        public override void increaseSalary()
        {
            double y = DateTime.Now.Year - dateOfJoining.Year;
            int x = (int)Math.Round(y, 1, MidpointRounding.AwayFromZero);

            if (x >= 1)
            {
                for (int i = 0; i < x; i++)
                {
                    Typewriter.salary_t += (salary_t * 0.05);
                }
            }
            else
            {
                ;
            }
        }
        public Typewriter(string name, string contact, DateTime dateOfJoining): base(name, contact, dateOfJoining)
        {
            setEmployeeID();
        }
    }
}
