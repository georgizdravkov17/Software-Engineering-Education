﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public string Name { get; private set; }

        public string FavouriteFood { get; private set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }

    }
}
