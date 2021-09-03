using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dividors =  { 2, 3, 6, 7, 10 };
            var number = int.Parse(Console.ReadLine());
            var biggestDividor = 0;


            for (int i = 0; i < dividors.Length; i++)
            {
                if(number % dividors[i] == 0 && biggestDividor < dividors[i])
                {
                    biggestDividor = dividors[i];
                }
            }

            if(biggestDividor == 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {biggestDividor}");
        }
    }
}
