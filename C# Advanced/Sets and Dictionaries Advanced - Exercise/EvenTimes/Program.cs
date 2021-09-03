using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < numbersCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(currentNumber))
                {
                    dict[currentNumber] = 0;
                }

                dict[currentNumber]++;
            }

            foreach (var item in dict)
            {
                if(item.Value > 1)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
