using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var dict = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {

                var currentNumber = input[i];
                if (!dict.ContainsKey(currentNumber))
                {
                    dict[currentNumber] = 0;
                }

                dict[currentNumber]++;

            }

            dict.OrderBy(i => i.Value);

            foreach(var number in dict)
            {
                var key = number.Key;
                var value = number.Value;
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
