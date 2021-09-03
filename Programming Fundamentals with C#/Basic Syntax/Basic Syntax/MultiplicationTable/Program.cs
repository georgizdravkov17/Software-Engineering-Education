using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var startNumber = int.Parse(Console.ReadLine());
            var result = 0;


            if (startNumber > 10)
            {
                 result = number * startNumber;
                Console.WriteLine($"{number} X {startNumber} = {result}");
            }

            else
            {
                for (int i = startNumber; i <= 10; i++)
                {
                    result = number * i;
                    Console.WriteLine($"{number} X {i} = {result}");
                }
            }

            
        }
    }
}
