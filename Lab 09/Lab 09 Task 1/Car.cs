using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_1
{
    internal class Car
    {
        private double maximum_acceleration;
        private double fuel_capacity;
        private Seat seat = new Seat();
        private Wheel wheel = new Wheel();
        private Engine engine = new Engine();
        private Door door = new Door();

        public void setMaximumAcceleration(double maximum_acceleration)
        {
            this.maximum_acceleration = maximum_acceleration;
        }

        public void setFuelCapacity(double fuel_capacity)
        {
            this.fuel_capacity = fuel_capacity;
        }

        public Seat getSeat()
        {
            return this.seat;
        }

        public Wheel getWheel()
        {
            return this.wheel;
        }

        public Engine getEngine()
        {
            return this.engine;
        }

        public Door getDoor()
        {
            return this.door;
        }

        public string displayInformation()
        {
            string info;

            info = "Car Information:" + "\n";
            info += "Maximum Acceleration= " + this.maximum_acceleration.ToString() + "mph" + "\n";
            info += "Fuel Capacity= " + this.fuel_capacity.ToString() + "litres" +"\n";
            info += "Seat:" + "\n";
            info += "Comfortability: " + seat.getComfortability() + "\n";
            info += "Wheel:" + "\n";
            info += "Circumference= " + wheel.getCircumference().ToString() + "square inches" + "\n";
            info += "Engine:" + "\n";
            info += "Maximum Fuel Consumption= " + engine.getMaximumFuelConsumptionRate().ToString() + "km/1-litre" + "\n";
            info += "Maximum Energy Production Rate= " + engine.getMaximumEnergyProductionRate().ToString() + "kWh" + "\n";
            info += "Average RPM= " + engine.getAverageRPM() + "\n";
            info += "Door:" + "\n";
            info += "Opening Mode= " + door.getOpeningMode() + "\n";

            return info;
        }
    }
}
