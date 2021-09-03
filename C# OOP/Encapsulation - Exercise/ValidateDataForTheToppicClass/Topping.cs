using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BASE_CALORIES = 2;

        private string type;
        private double weight;

        public Topping(string type,double weight)
        {
            this.Type = type;
            this.weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                ValidateTopicType(value);

                this.type = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException("Weight must be in range [1 to 50]");
                }

                this.weight = value;
            }
        }

        private void ValidateTopicType(string type)
        {
            if(type != "Meat" && type != "Veggies" && type != "Cheese" && type != "Sauce")
            {
                throw new ArgumentException($"Can not place {type} on top of your pizza.");
            }
        }

        public double TotalCalories()
        {
            double calories = 0;

            if(Type == "Meat")
            {
                calories = 1.2;
            }
            else if (Type == "Veggies")
            {
                calories = 0.8;
            }
            else if (Type == "Cheese")
            {
                calories = 1.1;
            }
            else if (Type == "Sauce")
            {
                calories = 0.9;
            }

            var result = (this.Weight * BASE_CALORIES) * calories;
            return result;
        }

       
    }
}
