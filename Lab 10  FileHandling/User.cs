using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10__FileHandling__Even_
{
    internal class User
    {
        private string first_name;
        private string last_name;
        private string address;
        private string city;
        private string county;
        private string state;
        private string zip;
        private string phone1;
        private string phone;
        private string email;

        public User(string first_name, string last_name, string address, string city, string county, 
                    string state, string zip, string phone1, string phone, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.city = city;
            this.county = county;
            this.state = state;
            this.zip = zip;
            this.phone1 = phone1;
            this.phone = phone;
            this.email = email;
        }

        public string getFirstName()
        {
            return this.first_name;
        }

        public string getLastName()
        {
            return this.last_name;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getInfo()
        {
            string info;
            info = "First Name: " + this.first_name + "\n";
            info += "Last Name: " + this.last_name + "\n";
            info += "Address: " + this.address + "\n";
            info += "City: " + this.city + "\n";
            info += "County: " + this.county + "\n";
            info += "State: " + this.state + "\n";
            info += "Zip: " + this.zip + "\n";
            info += "Phone1: " + this.phone1 + "\n";
            info += "Phone: " + this.phone + "\n";
            info += "Email: " + this.email + "\n";

            return info;
        }

    }
}
