using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
   public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name,decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
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
                    throw new ArgumentException("Name can not be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if(money <= 0)
                {
                    throw new ArgumentException("Money must be positive number");
                }

                this.money = value;
            }
        }

        public string BuyProduct(Product product)
        {
            if(this.Money < product.Cost)
            {
                return $"{this.Name} can't afford {product.Name}";
            }


            this.bag.Add(product);
            this.money -= product.Cost;

            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            var currentPersonDetails = String.Empty;

            if(this.bag.Count == 0)
            {
                currentPersonDetails = $"{this.Name} - Nothing bought.";
            }
            else
            {
                currentPersonDetails = $"{this.Name} - {string.Join(", ", bag)}";
            }
           
            return currentPersonDetails;
        }


    }
}
