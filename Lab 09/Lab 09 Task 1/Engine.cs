using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_1
{
    internal sealed class Engine
    {
        private double maximum_fuel_consumption_rate;
        private double maximum_energy_production_rate;
        private string average_rpm;

        public void setMaximumFuelConsumptionRate(double maximum_fuel_consumption_rate)
        {
            this.maximum_fuel_consumption_rate= maximum_fuel_consumption_rate;
        }

        public void setMaximumEnergyProductionRate(double maximum_energy_production_rate)
        {
            this.maximum_energy_production_rate= maximum_energy_production_rate;
        }

        public void setAverageRPM(string average_rpm)
        {
            this.average_rpm=average_rpm;
        }

        public double getMaximumFuelConsumptionRate()
        {
            return this.maximum_fuel_consumption_rate;
        }

        public double getMaximumEnergyProductionRate()
        {
            return this.maximum_energy_production_rate;
        }

        public string getAverageRPM()
        {
            return this.average_rpm;
        }
    }
}
