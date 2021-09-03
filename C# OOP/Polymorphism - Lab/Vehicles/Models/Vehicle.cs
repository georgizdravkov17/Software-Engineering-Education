using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity,double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelConsumption { get; set; }

        public double FuelQuantity { get; set; }

        public abstract string Drive(double kilometers);


        public abstract void Refuel(double liters);
        
        
    }
}
