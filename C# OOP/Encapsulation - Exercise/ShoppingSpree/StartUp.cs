using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
   public class StartUp
    {
       public static void Main(string[] args)
        {

            try
            {
                var personsInput = Console.ReadLine().Split(';').ToArray();

                var persons = new List<Person>();

                foreach (var person in personsInput)
                {
                    var personInfo = person.Split('=').ToArray();
                    var currentPersonName = personInfo[0];
                    var currentPersonMoney = decimal.Parse(personInfo[1]);

                    var currentPerson = new Person(currentPersonName, currentPersonMoney);

                    persons.Add(currentPerson);
                }

                var productInput = Console.ReadLine().Split('=').ToArray();

                var products = new List<Product>();

                foreach (var product in productInput)
                {
                    var productInfo = product.Split('=').ToArray();
                    var currentProductName = productInfo[0];
                    var currentProductCost = decimal.Parse(productInfo[1]);

                    var currentProduct = new Product(currentProductName, currentProductCost);

                    products.Add(currentProduct);
                }

                while (true)
                {
                    var currentOperation = Console.ReadLine().Split().ToArray();

                    if (currentOperation[0].Equals("End"))
                    {
                        break;
                    }

                    var personName = currentOperation[0];
                    var productName = currentOperation[1];

                    foreach (var person in persons)
                    {
                        if (personName.Equals(person.Name))
                        {
                            foreach (var product in products)
                            {
                                if (product.Name.Equals(productName))
                                {
                                    person.BuyProduct(product);
                                }
                            }
                        }
                    }

                    foreach (var person in persons)
                    {
                        Console.WriteLine(person.ToString());
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
