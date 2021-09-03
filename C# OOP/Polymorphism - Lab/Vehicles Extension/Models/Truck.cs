using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Extension.Models
{
    public class Truck : Vehicle
    {
        private const double AIR_CONDITIONDER_FUEL_INCREASMENT = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double kilometers)
        {
            var neededFuel = (this.FuelConsumption * kilometers *
                AIR_CONDITIONDER_FUEL_INCREASMENT);

            if (neededFuel > this.FuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} need to refuel!");
            }

            this.FuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {kilometers}";
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Liters to fuel must be positive number!");
            }

            if (liters > this.TankCapacity - this.FuelQuantity)
            {
                throw new ArgumentException($"Cannot fit {liters} liters in tank capacity!");
            }

            this.FuelQuantity += liters;
        }
    }
}
