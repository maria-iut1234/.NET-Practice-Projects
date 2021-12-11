using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_ClassLibrary
{
    public class Car
    {
        private string car_name;
        private string car_model;
        private int num_of_cars;

        public Car(string car_name, string car_model, int num_of_cars)
        {
            this.car_name = car_name;
            this.car_model = car_model;
            this.num_of_cars = num_of_cars;
        }

        public string getCarName
        {
            get { return car_name; }
        }

        public string getCarModel
        {
            get { return car_model; }
        }

        public int getNumOfCars
        {
            get { return num_of_cars; }
        }

        public int setNumOfCars
        {
            set { num_of_cars=value; }
        }
    }
}
