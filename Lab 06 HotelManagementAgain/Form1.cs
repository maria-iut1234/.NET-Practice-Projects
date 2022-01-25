using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06_HotelManagementAgain
{
    public partial class Form1 : Form
    {
        HotelManagementSystem hotel_management_system = new HotelManagementSystem();
        Account balance = new Account();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pant_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount(object sender, EventArgs e)
        {
            if(textBox_userID.Text=="" || textBox_name.Text=="" || textBox_address.Text=="" || textBox_contact.Text=="")
            {
                MessageBox.Show("Error: Input field empty!");
            }
            else
            {
                int userID = Convert.ToInt32(textBox_userID.Text);
                string name = textBox_name.Text;
                string address = textBox_address.Text;
                string contact = textBox_contact.Text;

                User dummy_user = new User(userID, name, address, contact);

                hotel_management_system.users.Add(dummy_user);

                MessageBox.Show("Account has been created successfully.");
            }
        }

        private void textBox_order_userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaceBooking(object sender, EventArgs e)
        {
            if (textBox_book_userID.Text == "" || comboBox_room.Text == "" || textBox_quantity.Text == "" || Convert.ToInt32(textBox_quantity.Text) <= 0)
            {
                MessageBox.Show("Error: Input field empty!");
            }
            else
            {
                int book_userID = Convert.ToInt32(textBox_book_userID.Text);
                string room_choice = comboBox_room.Text;
                int quantity = Convert.ToInt32(textBox_quantity.Text);
                int entry_date = Convert.ToInt32(textBox_entry.Text);
                int departure_date = Convert.ToInt32(textBox_dept.Text);

                for(int i=0; i<hotel_management_system.users.Count; i++)
                {
                    if (hotel_management_system.users[i].userID == book_userID && departure_date>entry_date)
                    {
                        Booking dummy_booking = new Booking(book_userID, room_choice, quantity, entry_date, departure_date);

                        hotel_management_system.bookings.Add(dummy_booking);

                       
                       

                        MessageBox.Show("Room has been booked successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error: Check input again!");
                    }
                }
            }
        }

        private void SetStatus(object sender, EventArgs e)
        {
            bool flag = false;

            int bookingID = Convert.ToInt32(textBox_bookingID.Text);
            string status = comboBox_status.Text;
            
            for(int i=0; i<hotel_management_system.bookings.Count; i++)
            {
                if(hotel_management_system.bookings[i].bookingID==bookingID)
                {
                    flag = true;
                }
            }

            if(flag==false)
            {
                MessageBox.Show("Error: booking ID not found!");
            }
            else
            {
                if(status=="Confirmed")
                {
                    textBox_roomNo.Visible = true;

                    int roomNo = Convert.ToInt32(textBox_roomNo.Text);
                }
            }
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_status.Text=="Confirmed")
            {
                textBox_roomNo.Visible = true;
            }
        }
    }
}
