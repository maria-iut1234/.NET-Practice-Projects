using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_EmployeeManagementSystem
{
    sealed internal class Salesperson:Employee
    {
        private static double salary_s = 10000.0;
        private static int employeeID = 20;
        public override void setDesignation(string x)
        {
            this.designation = "Salesperson";
        }
        public string getSalary()
        {
            return Salesperson.salary_s.ToString();
        }
        public void setEmployeeID()
        {
            Salesperson.employeeID++;
        }
        public int getEmployeeID()
        {
            return Salesperson.employeeID;
        }

        public override void increaseSalary()
        {
            double y = DateTime.Now.Year - dateOfJoining.Year;
            int x = (int)Math.Round(y, 1, MidpointRounding.AwayFromZero);

            if (x >= 1)
            {
                for (int i = 0; i < x; i++)
                {
                    Salesperson.salary_s += (salary_s * 0.10);
                }
            }
            else
            {
                ;
            }
        }
        public Salesperson(string name, string contact, DateTime dateOfJoining) : base(name, contact, dateOfJoining)
        {
            setEmployeeID();
        }
    }
}
