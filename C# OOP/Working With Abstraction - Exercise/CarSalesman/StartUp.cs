using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            var engines = new List<Engine>();

            var numbersOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfEngines; i++)
            {
                var currentEngineInfo = Console.ReadLine().Split().ToArray();

                
            }




            var cars = new List<Car>();

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var currentCarInfo = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
