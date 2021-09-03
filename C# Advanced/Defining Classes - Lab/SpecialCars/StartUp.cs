using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var tires = new List<Tire>();
            var engines = new List<Engine>();

            while (true)
            {
                var command = Console.ReadLine();


                if(command.Equals("No more tires"))
                {
                    break;
                }

                var currentTireInfo = command.Split();
                var t1Year = int.Parse(currentTireInfo[0]);
                var t1rePressure = double.Parse(currentTireInfo[1]);

                var t2Year = int.Parse(currentTireInfo[2]);
                var t2rePressure = double.Parse(currentTireInfo[3]);

                var t3Year = int.Parse(currentTireInfo[4]);
                var t3rePressure = double.Parse(currentTireInfo[5]);

                var t4Year = int.Parse(currentTireInfo[6]);
                var t4rePressure = double.Parse(currentTireInfo[7]);

                var firstTire = new Tire(t1Year, t1rePressure);
                var secondTire = new Tire(t2Year, t2rePressure);
                var thirdTire = new Tire(t3Year, t3rePressure);
                var fourthTire = new Tire(t4Year, t4rePressure);

                tires.Add(firstTire);
                tires.Add(secondTire);
                tires.Add(thirdTire);
                tires.Add(fourthTire);

            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("Engines done"))
                {
                    break;
                }

                var currentEngineInfo = command.Split();
                var engineHorsePower = int.Parse(currentEngineInfo[0]);
                var engineCubicCapacity = double.Parse(currentEngineInfo[1]);

                var currentEngine = new Engine(engineHorsePower, engineCubicCapacity);
            }

            while (true)
            {
                var command = Console.ReadLine();

                if(command.Equals("Show special"))
                {
                    break;
                }

                var currentCarInfo = command.Split();
                var carMake = currentCarInfo[0];
                var carModel = currentCarInfo[1];
                var carYear = int.Parse(currentCarInfo[2]);
                var carFuelQuantity = int.Parse(currentCarInfo[3]);
                var carFuelConsumption = int.Parse(currentCarInfo[4]);
                var engineIndex = int.Parse(currentCarInfo[5]);
                var tireIndex = int.Parse(currentCarInfo[6]);

                var currentCar = new Car(carMake,carModel,carYear,carFuelQuantity,
                    carFuelConsumption,engines[engineIndex],tires[tireIndex]);

                cars.Add(currentCar);
            }

            var acceptableCars = cars.Where(c => c.Engine.HorsePower >= 310);

            foreach (var car in acceptableCars)
            {
                Console.WriteLine($"Make:{car.Make}");
                Console.WriteLine($"Model:{car.Model}");
                Console.WriteLine($"Year:{car.Year}");
                Console.WriteLine($"FuelQuantity:{car.FuelQuantity}");
            }
        }
    }
}
