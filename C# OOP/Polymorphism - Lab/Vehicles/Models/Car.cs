using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override string Drive(double kilometers)
        {
            var isAbleToDrive = (this.FuelConsumption / this.FuelQuantity) < kilometers;

            if (!isAbleToDrive)
            {
                var exception =  $"{this.GetType().Name} need to refuel!";
                throw new ArgumentException(exception);
            }

            this.FuelQuantity -= this.FuelQuantity - (FuelConsumption / FuelQuantity);
            return $"{this.GetType().Name} travelled {kilometers} km.";

        }

        public override void Refuel(double liters)
        {
            if(liters <= 0)
            {
                throw new ArgumentException("Can't refuel negative number!");
            }

            this.FuelQuantity += liters;
        }
    }
}
