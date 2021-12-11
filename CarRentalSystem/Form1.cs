using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_ClassLibrary;


namespace Car_Rental_System
{
    public partial class CarRentalSystem : Form
    {
        List<User> users = new List<User>();
        List<Car> cars = new List<Car>();

        public CarRentalSystem()
        {
            InitializeComponent();
        }

        private void SaveUserButton(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(text_userID.Text);
            string user_name = text_user_name.Text;
            string address = text_address.Text;
            string destination = text_destination.Text;

            User dummy_user = new User(user_id, user_name, address, destination);
            users.Add(dummy_user);
            MessageBox.Show("User has been added successfully!");
        }

        private void SaveCarButton(object sender, EventArgs e)
        {
            string car_name = text_car_name.Text;
            string car_model = text_car_model.Text;
            int num_of_cars = Convert.ToInt32(text_num_of_cars.Text);

            if(num_of_cars<0)
            {
                MessageBox.Show("Quantity can not be negative.");
                return;
            }

            Car dummy_car = new Car(car_name, car_model, num_of_cars);
            cars.Add(dummy_car);
            MessageBox.Show("Car has been added successfully!");
        }

        private bool user_exists(int user_id)
        {
            foreach(User user in users)
            {
                if(user.getUserID==user_id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool car_exists(string car_name)
        {
            foreach(Car car in cars)
            {
                if(car.getCarName==car_name)
                {
                    return true;
                }
            }
            return false;
        }

        private void RentCarButton(object sender, EventArgs e)
        {
            int rent_user_id = Convert.ToInt32(text_rent_userID.Text);
            string rent_car_name = text_rent_car_name.Text;

            if(user_exists(rent_user_id) && car_exists(rent_car_name))
            {
                foreach(Car car in cars)
                {
                    if(car.getCarName == rent_car_name)
                    {
                        if(car.getNumOfCars<1)
                        {
                            MessageBox.Show("Not enough cars available.");
                            break;
                        }
                        car.setNumOfCars = car.getNumOfCars - 1;

                        foreach(User user in users)
                        {
                            if(user.getUserID==rent_user_id)
                            {
                                user.setRentedCar = rent_car_name;
                                MessageBox.Show("Car has been rented by the user.");
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Inavlid Input.");
            }

        }

        private void ShowUserHistoryButton(object sender, EventArgs e)
        {
            int search_userID = Convert.ToInt32(text_hist_userID.Text);
            bool flag = false;

            foreach(User user in users)
            {
                if(user.getUserID==search_userID)
                {
                    flag = true;
                    label_hist_user_name.Text = "User Name: " + user.getUserName;
                    label_hist_address.Text = "Address: " + user.getAddress;
                    label_hist_rented_car.Text = "Rented Car: " + user.getRentedCar;
                    label_hist_destination.Text = "Destination: " + user.getDestination;
                }
            }
            if(flag==false)
            {
                MessageBox.Show("User could not be found!");
            }

        }

        private void ShowCarHistoryButton(object sender, EventArgs e)
        {
            string hist_car_name = text_hist_car_name.Text;
            bool flag = false;

            foreach(Car car in cars)
            {
                if(car.getCarName==hist_car_name)
                {
                    flag = true;
                    label_hist_model.Text = "Model: " + car.getCarModel;
                    label_hist_available_unit.Text = "Available Unit: " + car.getNumOfCars.ToString();
                }
            }

            if(flag==false)
            {
                MessageBox.Show("Car could not be found!");
            }
        }
    }
}
