using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        List<SingleRoom> single_rooms = new List<SingleRoom>();
        List<DoubleRoom> double_rooms = new List<DoubleRoom>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddSingleRoom(object sender, EventArgs e)
        {
            string single_room_name = textBox_single_room_name.Text;
            int single_num_of_refrigerator=1;
            int single_num_of_TV=1;

            if(textBox_single_num_of_refrigerator.Text != "")
            {
                single_num_of_refrigerator = Convert.ToInt32(textBox_single_num_of_refrigerator.Text);
            }

            if(textBox_single_no_of_TV.Text!="")
            {
                single_num_of_TV = Convert.ToInt32(textBox_single_no_of_TV.Text);
            }
            
            int single_bed = 1;
            int single_quantity = Convert.ToInt32(textBox_single_quantity.Text);
            string single_air_conditioner = comboBox_single_air_conditioner.Text;
            string single_gaming_setup = comboBox_single_gaming.Text;

            SingleRoom dummy_single_room = new SingleRoom(single_room_name, single_num_of_TV, single_num_of_refrigerator, single_bed,
                                                        single_quantity, single_air_conditioner, single_gaming_setup);
            
            int single_cost= dummy_single_room.CalculateCost();

            single_rooms.Add(dummy_single_room);

            MessageBox.Show("Room has been added successfully!\n" + "Room Name: " + single_room_name + "\n"
                            + "Quantity: " + single_quantity + "\n" + "Cost: " + single_cost + "/day");

        }

        private void RentSingleRoom(object sender, EventArgs e)
        {

            for (int i=0; i<single_rooms.Count; i++)
            {
                if(single_rooms[i].room_name==textBox_rent_single_room_name.Text)
                {
                    if(Convert.ToInt32(textBox_rent_single_quantity.Text) <= single_rooms[i].quantity)
                    {
                        single_rooms[i].cost = single_rooms[i].CalculateCost();
                        int rent_single_room = (Convert.ToInt32(textBox_rent_single_quantity.Text)) * single_rooms[i].cost;
                        MessageBox.Show("Room has been rented successfully!\n" + "Cost:" + rent_single_room);
                        single_rooms[i].quantity -= Convert.ToInt32(textBox_rent_single_quantity.Text);
                    }
                    else
                    {
                        MessageBox.Show("Not enough rooms available.");
                    }
                }
                else
                {
                    MessageBox.Show("Room does not exist.");
                }
            }
        }

        private void ShowSingleRoom(object sender, EventArgs e)
        {
            string show_single_room = textBox_show_single_room.Text;

            for(int i=0; i<single_rooms.Count; i++)
            {
                if(show_single_room==single_rooms[i].room_name)
                {
                    show_single_quantity.Text = "Quantity: " + single_rooms[i].quantity;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDoubleRoom(object sender, EventArgs e)
        {
            string double_room_name = textBox_double_room_name.Text;
            int double_num_of_refrigerator = 1;
            int double_num_of_TV = 1;

            if (textBox_double_num_of_refrigerator.Text != "")
            {
                double_num_of_refrigerator = Convert.ToInt32(textBox_double_num_of_refrigerator.Text);
            }

            if (textBox_double_num_of_TV.Text != "")
            {
                double_num_of_TV = Convert.ToInt32(textBox_double_num_of_TV.Text);
            }

            int double_bed = 1;
            int double_quantity = Convert.ToInt32(textBox_double_quantity.Text);
            string double_air_conditioner = comboBox_double_air_conditioner.Text;
            string double_extra_TV = comboBox_double_extra_TV.Text;
            string double_complimentary_breakfast = comboBox_double_breakfast.Text;

            DoubleRoom dummy_double_room = new DoubleRoom(double_room_name, double_num_of_TV, double_num_of_refrigerator, double_bed,
                                                        double_quantity, double_air_conditioner, double_extra_TV, double_complimentary_breakfast);

            int double_cost = dummy_double_room.CalculateCost();

            double_rooms.Add(dummy_double_room);

            MessageBox.Show("Room has been added successfully!\n" + "Room Name: " + double_room_name + "\n"
                            + "Quantity: " + double_quantity + "\n" + "Cost: " + double_cost + "/day");
        }

        private void RentDoubleRoom(object sender, EventArgs e)
        {
            for (int i = 0; i < double_rooms.Count; i++)
            {
                if (double_rooms[i].room_name == textBox_rent_double_room.Text)
                {
                    if (Convert.ToInt32(textBox_rent_double_quantity.Text) <= double_rooms[i].quantity)
                    {
                        double_rooms[i].cost = double_rooms[i].CalculateCost();
                        int rent_double_room = (Convert.ToInt32(textBox_rent_double_quantity.Text)) * double_rooms[i].cost;
                        MessageBox.Show("Room has been rented successfully!\n" + "Cost:" + rent_double_room);
                        double_rooms[i].quantity -= Convert.ToInt32(textBox_rent_double_quantity.Text);
                    }
                    else
                    {
                        MessageBox.Show("Not enough rooms available.");
                    }
                }
                else
                {
                    MessageBox.Show("Room does not exist.");
                }
            }
        }

        private void ShowDoubleRoom(object sender, EventArgs e)
        {
            string show_double_room = textBox_show_double_room.Text;

            for (int i = 0; i < double_rooms.Count; i++)
            {
                if (show_double_room == double_rooms[i].room_name)
                {
                    show_double_quantity.Text = "Quantity: " + double_rooms[i].quantity;
                }
            }
        }
    }
}
