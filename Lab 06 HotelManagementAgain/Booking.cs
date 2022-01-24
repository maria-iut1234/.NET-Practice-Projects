using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_HotelManagementAgain
{
    internal class Booking
    {
        public int book_userID;
        public string room_choice;
        public int quantity;
        public int entry_date;
        public int departure_date;
        public int room_no;
        public string room_status = "Pending";
        public int bookingID = 1;

        public Booking(int bookUserID, string room_choice, int quantity, int entry_date, int departure_date)
        {
            this.room_choice = room_choice;
            this.book_userID = bookUserID;
            this.quantity = quantity;
            this.entry_date = entry_date;
            this.departure_date = departure_date;

            bookingID++;
        }

        public int CountDays(int entry, int dept)
        {
            return dept - entry;
        }
    }
}
