using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class EletricCar : ICar, IElectricCar
    {
        public EletricCar(string model,string color,int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Battery { get; private set; }

        public string Start()
        {
            return "Electric car engine is ON!";
        }

        public string Stop()
        {
            return "Electric car engine is OFF";
        }

        public override string ToString()
        {
            return $"++++{this.Model} {this.Color} {this.Battery}";
        }
    }
}
