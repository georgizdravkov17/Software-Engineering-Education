using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                var currentSymbol = text[i];
                if (!dict.ContainsKey(currentSymbol))
                {
                    dict[currentSymbol] = 0;
                }

                dict[currentSymbol]++;
            }

            foreach (var symbol in dict.OrderBy(s => s.Key))
            {
                var symbolChar = symbol.Key;
                var count = symbol.Value;

                Console.WriteLine($"{symbolChar}: {count} time/s");
            }
        }
    }
}
