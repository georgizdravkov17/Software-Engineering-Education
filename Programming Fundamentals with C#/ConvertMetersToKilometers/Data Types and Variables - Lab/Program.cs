using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = double.Parse(Console.ReadLine());

            double kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
