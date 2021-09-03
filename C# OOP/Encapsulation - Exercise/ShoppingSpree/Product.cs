using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
   public class Product 
    {
        private string name;
        private decimal cost;
        

        public Product(string name,decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty!");
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Cost must be more than zero.");
                }
                this.cost = value;
            }
        }


        public override string ToString()
        {
            return $"Product:{this.Name} costs {this.Cost:F2} leva";
        }
    }
}
