using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var result = Order(product, quantity);

            Console.WriteLine($"{result:F2}");
        }
        public static double Order(string product,int quantity)
        {
            var products = new Dictionary<string, double>();

            double price = 0;
            

            products["coffee"] = 1.50;
            products["water"] = 1.00;
            products["coke"] = 1.40;
            products["snacks"] = 2.00;

            if (products.ContainsKey(product))
            {
                price = products[product];
            }

            return price * quantity;

            
        }
    }
}
