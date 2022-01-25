using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_HotelManagementAgain
{
    internal class Account
    {
        public double balance = 1000;

        public double BookingPrice(int quantity, double price)
        {
            return quantity * price;
        }

     
    }
}
