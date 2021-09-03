using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {


            Car car = new Car()
            {
                Make = "VW",
                Model = "MK3",
                Year = 1992
            };

            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);

        }
    }
}
