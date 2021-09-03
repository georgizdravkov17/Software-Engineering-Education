using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
            {
            var cars = new HashSet<string>();

            while (true)
            {
                var currentCar = Console.ReadLine().Split(new char[] {',',' ' }
                ,StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currentCar[0].Equals("END"))
                {
                    break;
                }

                var direction = currentCar[0];
                var carNumber = currentCar[1];

                if (direction.Equals("IN"))
                {
                    cars.Add(carNumber);
                }
                else if (direction.Equals("OUT") && cars.Contains(carNumber))
                {                  
                   cars.Remove(carNumber);              
                }
            }

            if(cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
