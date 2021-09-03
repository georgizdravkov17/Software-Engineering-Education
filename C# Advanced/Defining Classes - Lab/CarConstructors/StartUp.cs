using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructors
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            var firstCar = new Car();
            var secondCar = new Car(make,model,year);
            var thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine($"{firstCar.Make} {firstCar.Model} {firstCar.Year} " +
                $"{firstCar.FuelQuantity} {firstCar.FuelConsumption}");

            Console.WriteLine($"{secondCar.Make} {secondCar.Model} {secondCar.Year} " +
                $"{secondCar.FuelQuantity} {secondCar.FuelConsumption}");

            Console.WriteLine($"{thirdCar.Make} {thirdCar.Model} {thirdCar.Year} " +
                $"{thirdCar.FuelQuantity} {thirdCar.FuelConsumption}");

            var tires = new Tire[4]
            {
                 new Tire(1,1.5),
                 new Tire(1, 1.25),
                 new Tire(2,2.50),
                 new Tire(2,2.25)
            };

            var engine = new Engine(500, 6300);

            var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);

            Console.WriteLine($"{thirdCar.Make} {thirdCar.Model} {thirdCar.Year} " +
                $"{thirdCar.FuelQuantity} {thirdCar.FuelConsumption} {engine.HorsePower} {engine.CubicCapacity}");
        }
    }
}
