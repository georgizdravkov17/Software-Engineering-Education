using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;

namespace Vehicles
{
   public class StartUp
    {
       public static void Main(string[] args)
        {

            string[] carArguments = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();


            var carFuelQuantity = double.Parse(carArguments[1]);
            var carFuelConsumption = double.Parse(carArguments[2]);
            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);

            string[] truckArguments = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var truckFuelQuantity = double.Parse(truckArguments[1]);
            var truckFuelConsumption = double.Parse(truckArguments[2]);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            var numberOfCommands = int.Parse(Console.ReadLine());

            try
            {
                for (int i = 0; i < numberOfCommands; i++)
                {
                    var currentCommand = Console.ReadLine().Split().ToArray();

                    var command = currentCommand[0];
                    var currentVehicleName = currentCommand[1];
                    var ammount = double.Parse(currentCommand[2]);

                    if (command.Equals("Drive"))
                    {
                        if (currentVehicleName.Equals("Car"))
                        {
                            Console.WriteLine(car.Drive(ammount));
                        }
                        else if (currentVehicleName.Equals("Truck"))
                        {
                            Console.WriteLine(truck.Drive(ammount));
                        }
                    }
                    else if (command.Equals("Refuel"))
                    {
                        if (currentVehicleName.Equals("Car"))
                        {
                            car.Refuel(ammount);
                        }
                        else if (currentVehicleName.Equals("Truck"))
                        {
                            truck.Refuel(ammount);
                        }
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine(car.FuelQuantity);
                Console.WriteLine(truck.FuelQuantity);
            }

        }       
    }
}
