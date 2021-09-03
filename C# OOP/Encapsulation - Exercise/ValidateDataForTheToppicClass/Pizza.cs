using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
   public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dought;

        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
            this.dought = dought;
            
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) && value.Length > 15)
                {
                    throw new ArgumentException("Pizza name can not be empty.");
                }

                this.name = value;
            }
        }

        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
            private set
            {
                if(this.toppings.Count > 10)
                {
                    throw new ArgumentException("Topping must be in range [0 to 10].");
                }
                this.toppings = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dought;
            }
            private set
            {
                this.dought = value;
            }
        }

        public double TotalCalories()
        {
            double result = 0;
            foreach (var topping in toppings)
            {
                result += topping.TotalCalories();
            }

            result += dought.TotalCalories();

            return result;
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public void AddDough(Dough dough)
        {
            
        }
    }
}
