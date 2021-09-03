using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] % 2 == 0)
                {
                    sum += input[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
