using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccuranves
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i].ToLower();
                if (!dict.ContainsKey(currentWord))
                {
                    dict[currentWord] = 0;
                }

                dict[currentWord]++;
            }

            foreach (var word in dict)
            {
                var key = word.Key;
                var value = word.Value;
                if(value % 2 != 0)
                {
                    Console.Write($"{key} ");
                }
            }
        }
    }
}
