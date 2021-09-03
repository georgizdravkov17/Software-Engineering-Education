using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDate
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbersOfCars = int.Parse(Console.ReadLine());

            var cars = new HashSet<Car>();

            for (int i = 0; i < numbersOfCars; i++)
            {
                var currentCarInfo = Console.ReadLine().Split().ToArray();

                var currentCarModel = currentCarInfo[0];

                var engineSpeed = int.Parse(currentCarInfo[1]);
                var enginePower = int.Parse(currentCarInfo[2]);
                var currentEngine = new Engine(engineSpeed, enginePower);

                var cargoWeight = int.Parse(currentCarInfo[3]);
                var cargoType = currentCarInfo[4];
                var currentCargo = new Cargo(cargoWeight, cargoType);

                var tire1Pressure = double.Parse(currentCarInfo[5]); 
                var tire1Age = int.Parse(currentCarInfo[6]);
                var currentTire1 = new Tire(tire1Pressure, tire1Age);

                var tire2Pressure = double.Parse(currentCarInfo[7]);
                var tire2Age = int.Parse(currentCarInfo[8]);
                var currentTire2 = new Tire(tire2Pressure, tire2Age);

                var tire3Pressure = double.Parse(currentCarInfo[9]);
                var tire3Age = int.Parse(currentCarInfo[10]);
                var currentTire3 = new Tire(tire3Pressure, tire3Age);

                var tire4Pressure = double.Parse(currentCarInfo[11]);
                var tire4Age = int.Parse(currentCarInfo[12]);
                var currentTire4 = new Tire(tire4Pressure, tire4Age);

                var currentCarTires = new Tire[]
                {
                    currentTire1,
                    currentTire2,
                    currentTire3,
                    currentTire4
                };

                var currentCar = new Car(currentCarModel, currentEngine, currentCargo, currentCarTires);

                cars.Add(currentCar);
            }

            var command = Console.ReadLine();

            foreach (var car in cars)
            {
                if (command.Equals("fragile") && car.Cargo.CargoType == "fragile" && car.Tires.Any(t => t.Pressure < 1))
                {
                    Console.WriteLine(car.Model);
                }
                else if (command.Equals("flamable") && car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }

            
        }
    }
}
