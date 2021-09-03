using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles_Extension.Contracts;

namespace Vehicles_Extension.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity,double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            set
            {
                if (value < 0 || value > this.tankCapacity)
                {
                    throw new ArgumentException($"{this.GetType().Name} can't start with negative number of fuel or fuel amount can't be more than tank capacity!");
                }

                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException($"{this.GetType().Name} can't have negative fuel consumption ");
                }

                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException($"{this.GetType().Name} can't have negative tank capacity!");
                }

                this.tankCapacity = value;
            }
        }


        public abstract string Drive(double kilometers);


        public abstract void Refuel(double liters);
    }
}
