using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string,Dictionary<string,double>>();

            while (true)
            {
                string[] currentLine = Console.ReadLine().Split(new char[] { ',',' '},
                    StringSplitOptions.RemoveEmptyEntries);
                

                if (currentLine[0].Equals("Revision"))
                {
                    break;
                }

                var shopName = currentLine[0];
                var productName = currentLine[1];
                var productPrice = double.Parse(currentLine[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();
                    
                }

                if (!shops[shopName].ContainsKey(productName))
                {
                    shops[shopName].Add(productName, productPrice);
                }


            }

            foreach (var shop in shops)
            {
                var shopName = shop.Key;
                var products = shop.Value;

                Console.WriteLine($"{shopName}->");

                foreach (var product in products)
                {
                    var productName = product.Key;
                    var productPrice = product.Value;

                    Console.WriteLine($"Product: {productName}, Price: {productPrice}");
                }
            }
        }
    }
}
