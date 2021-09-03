using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var evenSum = 0;
            var oddSum = 0;
            var result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentNumber = input[i];
                if(currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
