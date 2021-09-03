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

            var products = new List<Product>();

            while (true)
            {
                var currentProduct = Console.ReadLine().Split();

                if (currentProduct[0].Equals("buy"))
                {
                    break;
                }

                var productName = currentProduct[0];
                var price = double.Parse(currentProduct[1]);
                var quantity = int.Parse(currentProduct[2]);

                var product = new Product(productName, price, quantity);

                products.Add(product);
            }

            foreach (var product in products)
            {
                var totalPrice = product.Quantity * product.Price;

                Console.WriteLine($"{product.Name} -> {totalPrice:F2}");
            }
        }
    }
}
