using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_EmployeeManagementSystem
{
    sealed internal class Manager:Employee
    {
        private static double salary_m = 15000.0;
        private static int employeeID = 30;
        public override void setDesignation(string x)
        {
            this.designation = "Manager";
        }

        public string getSalary()
        {
            return Manager.salary_m.ToString();
        }
        public void setEmployeeID()
        {
            Manager.employeeID++;
        }
        public int getEmployeeID()
        {
            return Manager.employeeID;
        }

        public override void increaseSalary()
        {
            double y = DateTime.Now.Year - dateOfJoining.Year;
            int x = (int)Math.Round(y, 1, MidpointRounding.AwayFromZero);

            if (x >= 1)
            {
                for (int i = 0; i < x; i++)
                {
                    Manager.salary_m += (salary_m * 0.15);
                }
            }
            else
            {
                ;
            }
        }
        public Manager(string name, string contact, DateTime dateOfJoining) : base(name, contact, dateOfJoining)
        {
            setEmployeeID();
        }
    }
}
