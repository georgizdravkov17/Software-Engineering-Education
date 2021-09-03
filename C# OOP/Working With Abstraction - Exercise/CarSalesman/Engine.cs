using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
   public class Engine
    {
        public Engine(string model,int power)
        {
            this.Model = model;
            this.Power = power;

        }

        public Engine(string model,int power,int displacement):this(model,power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model,int power,string efficiency):this(model,power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model,int power,int displacement,string efficiency):this(model,power,displacement)
        {
            this.Efficiency = efficiency;
        }

        public string Model { get; private set; }

        public int Power { get; private set; }

        public int Displacement { get; private set; }

        public string Efficiency { get; private set; }

        public override string ToString()
        {
            return $"{this.Model} {this.Power} {this.Displacement} {this.Efficiency}";
        }
    }
}
