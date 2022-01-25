using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_HotelManagementAgain
{
    internal class User
    {
        public int userID;
        public string name;
        public string address;
        public string contact;

        public User(int userID, string name, string address, string contact)
        {
            this.userID = userID;
            this.name = name;
            this.address = address;
            this.contact = contact;
        }
    }
}
