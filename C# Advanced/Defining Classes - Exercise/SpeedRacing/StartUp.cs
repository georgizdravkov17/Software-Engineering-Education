using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new HashSet<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var currentCarInfo = Console.ReadLine().Split().ToArray();

                var currentCarModel = currentCarInfo[0];
                var currentCarFuelAmount = double.Parse(currentCarInfo[1]);
                var currentCarFuelPerKilometer = double.Parse(currentCarInfo[2]);

                var currentCar = new Car(currentCarModel, currentCarFuelAmount, currentCarFuelPerKilometer);
                cars.Add(currentCar);
            }

            while (true)
            {
                var currentLine = Console.ReadLine().Split().ToArray();
                var command = currentLine[0];

                if (command.Equals("End"))
                {
                    break;
                }

                else if (command.Equals("Drive"))
                {
                    var carModel = currentLine[1];
                    var amountOfKilometers = double.Parse(currentLine[2]);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
