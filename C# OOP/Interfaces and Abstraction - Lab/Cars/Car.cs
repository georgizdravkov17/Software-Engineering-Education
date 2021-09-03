using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car : ICar
    {
        public Car(string model,string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; private set; }

        public string Color { get;private set; }

        public string Start()
        {
            return "Car engine is ON!";
        }

        public string Stop()
        {
            return "Car engine is OFF";
        }

        public override string ToString()
        {
            return $"----{this.Model} {this.Color}";
        }
    }
}
