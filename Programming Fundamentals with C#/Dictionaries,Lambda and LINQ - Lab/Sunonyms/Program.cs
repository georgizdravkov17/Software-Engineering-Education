using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<String>>();

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var sunonym = Console.ReadLine();

                if (!dict.ContainsKey(word))
                {
                    dict[word] = new List<string>();
                    
                }

                dict[word].Add(sunonym);
            }

            foreach (var word in dict)
            {
                var key = word.Key;
                var value = word.Value;

                Console.WriteLine($"{key} - {string.Join(", ",value)}");
            }
        }
    }
}
