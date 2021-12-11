using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_ClassLibrary
{
    public class User
    {
        private int user_id;
        private string user_name;
        private string address;
        private string destination;
        private string rented_car;

        public User(int user_id, string user_name, string address, string destination)
        {
            this.user_id = user_id;
            this.user_name = user_name;
            this.address = address;
            this.destination = destination;
        }

        public int getUserID
        {
            get { return user_id; }
        }

        public string getUserName
        {
            get { return user_name; }
        }

        public string getAddress
        {
            get { return address; }
        }

        public string getDestination
        {
            get { return destination; }
        }

        public string getRentedCar
        {
            get { return rented_car; }
        }

        public string setRentedCar
        {
            set { rented_car = value; }
        }
    }
}
