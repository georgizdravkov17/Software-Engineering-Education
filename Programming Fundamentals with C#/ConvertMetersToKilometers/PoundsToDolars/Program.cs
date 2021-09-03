using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PoundsToDolars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            double dolars = pounds * 1.31;

            Console.WriteLine($"{dolars:F3}");
        }
    }
}
