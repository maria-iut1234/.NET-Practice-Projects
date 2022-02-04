using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_EmployeeManagementSystem
{
    abstract internal class Employee
    {
        protected string name;
        protected string designation;
        protected string contact;
        protected DateTime dateOfJoining;

        public virtual void setDesignation(string x)
        {
            this.designation = x;
        }

        public void setName(string x)
        {
            this.name = x;
        }
        public string getName()
        {
            return this.name;
        }
        public string getDesignation()
        {
            return this.designation;
        }
        public string getContact()
        {
            return this.contact;
        }

        public string getDate()
        {
            return this.dateOfJoining.ToString();
        }

        public void setContact(string x)
        {
            this.contact = x;
        }
        public void setDate(DateTime x)
        {
            this.dateOfJoining = x;
        }

        public virtual void increaseSalary()
        {
            ;
        }

        public Employee(string name, string contact, DateTime dateOfJoining)
        {
            this.name = name;
            setDesignation(null);
            this.contact = contact;
            this.dateOfJoining = dateOfJoining;
            increaseSalary();
        }
    }
}
