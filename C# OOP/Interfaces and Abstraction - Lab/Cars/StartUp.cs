using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
   public class StartUp
    {
       public static void Main(string[] args)
        {

            var cars = new List<ICar>();

            var numbersOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfCars; i++)
            {
                var currentCarArguments = Console.ReadLine().Split().ToArray();

                var currentCarModel = currentCarArguments[0];
                var currentCarColor = currentCarArguments[1];

                if(currentCarArguments.Length == 2)
                {
                    var currentCar = new Car(currentCarModel, currentCarColor);

                    cars.Add(currentCar);
                }
                else if(currentCarArguments.Length == 3)
                {
                    var currentCarBattery = int.Parse(currentCarArguments[2]);

                    var currentElectricCar = new EletricCar(currentCarModel, currentCarColor, currentCarBattery);

                    cars.Add(currentElectricCar);
                }
            }

            foreach (var car in cars)
            {
                if(car is Car)
                {
                    Console.WriteLine(car.ToString());
                }
                else if(car is EletricCar)
                {
                    Console.WriteLine(car.ToString());
                }
            }
           
        }
    }
}
