﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name,int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public int Food { get; private set; }

        public int BuyFood()
        {
            this.Food += 10;

            return this.Food;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Group}";
        }
    }
}
