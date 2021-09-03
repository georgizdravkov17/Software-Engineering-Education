using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstSetLenght = input[0];
            var secondSetLenght = input[1];

            var firstSet = new HashSet<int>();

            var secondSet = new HashSet<int>();

            var sameNumbers = new HashSet<int>();

            for (int i = 0; i < firstSetLenght; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                firstSet.Add(currentNumber);
            }

            for (int i = 0; i < secondSetLenght; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumber);
            }

            

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    sameNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ",sameNumbers));
        }
    }
}
