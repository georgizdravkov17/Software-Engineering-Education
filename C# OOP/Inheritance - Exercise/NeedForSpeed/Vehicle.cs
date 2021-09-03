using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        

        public Vehicle(int horsePower,double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;

        }

        public int HorsePower { get; private set; }
        public double Fuel { get; private set; }
        public virtual double FuelConsumption { get; private set; }
        public double DefaultFuelConsumption { get; private set; }


        public virtual void Drive()
        {

        }
    }
}
