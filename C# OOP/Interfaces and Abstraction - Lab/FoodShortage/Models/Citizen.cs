using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Citizen :  IBuyer
    {
        public Citizen(string name,int age,string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public int BuyFood()
        {
            this.Food += 5;

            return this.Food;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.ID} {this.Birthdate}";
        }
    }
}
