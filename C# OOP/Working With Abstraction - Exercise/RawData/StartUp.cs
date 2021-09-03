using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var numbersOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numbersOfCars; i++)
            {
                var currentCarArguments = Console.ReadLine().Split().ToArray();

                var carModel = currentCarArguments[0];

                var carEngineSpeed = int.Parse(currentCarArguments[1]);
                var carEnginePower = int.Parse(currentCarArguments[2]);

                var carCargoWeight = int.Parse(currentCarArguments[3]);
                var carCargoType = currentCarArguments[4];

                var tire1Pressure = double.Parse(currentCarArguments[5]);
                var tire1Age = int.Parse(currentCarArguments[6]);

                var tire2Pressure = double.Parse(currentCarArguments[7]);
                var tire2Age = int.Parse(currentCarArguments[8]);

                var tire3Pressure = double.Parse(currentCarArguments[9]);
                var tire3Age = int.Parse(currentCarArguments[10]);

                var tire4Pressure = double.Parse(currentCarArguments[11]);
                var tire4Age = int.Parse(currentCarArguments[12]);

                var carEngine = EngineCreation(carEngineSpeed,carEnginePower);
                var carCargo = CargoCreation(carCargoWeight, carCargoType);

                var tires = new Tire[]
                {
                    TireCreation(tire1Pressure,tire1Age),
                    TireCreation(tire2Pressure,tire2Age),
                    TireCreation(tire3Pressure,tire3Age),
                    TireCreation(tire4Pressure,tire4Age),
                   
                };

                var car = new Car(carModel, carEngine, carCargo, tires);

                cars.Add(car);

            }

            var cargoType = Console.ReadLine();

            if(cargoType == "fragile")
            {
                foreach (var car in cars.Where(c => c.Tires.Any(t => t.TirePresuure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if(cargoType == "flamable")
            {
                foreach (var car in cars.Where(c => c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }

        public static Engine EngineCreation(int engineSpeed,int enginePower)
        {
            var engine = new Engine(engineSpeed, enginePower);

            return engine;
        }

        public static Cargo CargoCreation(int cargoWeight,string cargoType)
        {
            var cargo = new Cargo(cargoWeight, cargoType);

            return cargo;
        }

        public static Tire TireCreation(double tirePressure, int tireAge)
        {
            var tire = new Tire(tirePressure,tireAge);
            return tire;
        }
    }
}
