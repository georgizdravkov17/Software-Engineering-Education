﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDate
{
    class Tire
    {
        private double pressute;
        private int age;

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        public double Pressure
        {
            get
            {
                return this.pressute;
            }

            set
            {
                this.pressute = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age; 
            }
            set
            {
                this.age = value;
            }
        }
    }
}