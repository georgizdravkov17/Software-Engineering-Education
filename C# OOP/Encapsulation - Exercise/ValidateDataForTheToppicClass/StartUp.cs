using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
   public class Program
    {
       public static void Main(string[] args)
        {
            try
            {

                var pizzaName = Console.ReadLine();

                var pizza = new Pizza(pizzaName);

                while (true)
                {
                    var arguments = Console.ReadLine().Split().ToArray();
                    var type = arguments[0].ToLower();

                    if (type.Equals("end"))
                    {
                        break;
                    }
                    else if (type.Equals("topping"))
                    {
                        var toppingType = arguments[1];
                        var toppingWeight = double.Parse(arguments[2]);

                        var topping = new Topping(toppingType, toppingWeight);

                        pizza.AddTopping(topping);
                    }
                    else if (type.Equals("dough"))
                    {
                        var doughFloorType = arguments[1];
                        var doughBackingTechnique = arguments[2];
                        var doughWeight = double.Parse(arguments[3]);

                        var dough = new Dough(doughFloorType, doughBackingTechnique, doughWeight);

                        pizza.AddDough(dough);

                        
                    }                 
                }

                Console.WriteLine($"{pizza.TotalCalories():F2}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
