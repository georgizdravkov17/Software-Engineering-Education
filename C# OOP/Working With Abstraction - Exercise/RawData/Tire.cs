using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
   public class Tire
    {
        public Tire(double tirePressure, int tireAge)
        {
            this.TirePresuure = tirePressure;

            this.TireAge = tireAge;
        }


        public double TirePresuure { get; private set; }

        public int TireAge { get; private set; }
    }
}
