using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_09_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCarInfo(object sender, EventArgs e)
        {
            Car dummy_car = new Car();

            dummy_car.setMaximumAcceleration(60.0);
            dummy_car.setFuelCapacity(57.0);
            dummy_car.getSeat().setComfortability("Pleasant");
            dummy_car.getWheel().setRadius(18.0);
            dummy_car.getEngine().setMaximumFuelConsumptionRate(18.75);
            dummy_car.getEngine().setMaximumEnergyProductionRate(46.5);
            dummy_car.getEngine().setAverageRPM("720 RPMs");
            dummy_car.getDoor().setOpeningMode("Upward Ways");

            label_show.Text = dummy_car.displayInformation();
        }
    }
}
