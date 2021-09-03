using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var numbers = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!numbers.ContainsKey(input[i]))
                {
                    numbers[input[i]] = 0;
                }

                numbers[input[i]]++;
            }

            foreach (var number in numbers)
            {
                var key = number.Key;
                var value = number.Value;

                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
