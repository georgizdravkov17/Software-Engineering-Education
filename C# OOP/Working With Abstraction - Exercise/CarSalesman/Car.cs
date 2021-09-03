using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
   public class Car
    {
        public Car(string model,Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model,Engine engine, double weight):this(model,engine)
        {
            this.Weight = weight;
        }

        public Car(string model,Engine engine,string color):this(model,engine)
        {
            this.Color = color;
        }

        public Car(string model,Engine engine,double weight,string color):this(model,engine,color)
        {
            this.Weight = weight;
        }

        public string Model { get; private set; }

        public Engine Engine { get; private set; }

        public double Weight { get; private set; }

        public string Color { get; private set; }

        public override string ToString()
        {
            return $"{this.Model} {this.Engine} {this.Weight} {this.Color}";
        }
    }
}
