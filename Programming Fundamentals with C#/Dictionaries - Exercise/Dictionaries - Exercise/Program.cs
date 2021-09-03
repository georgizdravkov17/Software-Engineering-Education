using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentElement = input[i];
                if(currentElement != ' ')
                {
                    if (!dict.ContainsKey(currentElement))
                    {
                        dict[currentElement] = 0;
                    }

                    dict[currentElement]++;
                }
            }

            foreach (var symbol in dict)
            {
                var key = symbol.Key;
                var value = symbol.Value;

                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
