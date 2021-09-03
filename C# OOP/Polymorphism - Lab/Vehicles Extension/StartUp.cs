using System;
using System.Linq;
using Vehicles_Extension.Models;

namespace Vehicles_Extension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carArguments = Console.ReadLine().Split(new char[] { ' ' }
         , StringSplitOptions.RemoveEmptyEntries).ToArray();

            var carFuelQuantity = double.Parse(carArguments[1]);
            var carFuelConsumption = double.Parse(carArguments[2]);
            var carTankCapacity = double.Parse(carArguments[3]);

            Vehicle car;

            try
            {
                car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            var truckArguments = Console.ReadLine().Split(new char[] { ' ' }
           , StringSplitOptions.RemoveEmptyEntries).ToArray();

            var truckFuelQuantity = double.Parse(truckArguments[1]);
            var truckFuelConsumption = double.Parse(truckArguments[2]);
            var truckTankCapacity = double.Parse(truckArguments[3]);

            Vehicle truck;

            try
            {
                truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }


            var busArguments = Console.ReadLine().Split(new char[] { ' ' }
           , StringSplitOptions.RemoveEmptyEntries).ToArray();

            var busFuelQuantity = double.Parse(busArguments[1]);
            var busFuelConsumption = double.Parse(busArguments[2]);
            var busTankCapacity = double.Parse(busArguments[3]);
            var busPessengers = int.Parse(busArguments[4]);

            Vehicle bus;

            try
            {
                bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity, busPessengers);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            var commandsNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < commandsNumber; i++)
            {
                var currentCommandArguments = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                var commandType = currentCommandArguments[0];
                var vehicleType = currentCommandArguments[1];
                var ammount = double.Parse(currentCommandArguments[2]);

                if (commandType.Equals("Drive"))
                {
                    switch (vehicleType)
                    {
                        case "Car": Console.WriteLine(car.Drive(ammount)); break;
                        case "Truck": Console.WriteLine(truck.Drive(ammount)); break;
                        case "Bus": Console.WriteLine(bus.Drive(ammount)); break;
                    }
                }
                else if (commandType.Equals("Refuel"))
                {
                    switch (vehicleType)
                    {
                        case "Car": car.Refuel(ammount); break;
                        case "Truck": truck.Refuel(ammount); break;
                        case "Bus": bus.Refuel(ammount); break;
                    }
                }
            }

            Console.WriteLine(car.FuelQuantity);
            Console.WriteLine(truck.FuelQuantity);
            Console.WriteLine(bus.FuelQuantity);
        }

    }
}

