using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var currentRow = Console.ReadLine().Split();

                var color = currentRow[0];

                if (!clothes.ContainsKey(color))
                {
                    clothes[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < currentRow.Length; j++)
                {
                    var currentItem = currentRow[j];

                    if (!clothes[color].ContainsKey(currentItem))
                    {
                        clothes[color][currentItem] = 0;
                    }

                    clothes[color][currentItem]++;


                }

            }
            var colorClothing = Console.ReadLine().Split();

            foreach (var colorr in clothes)
            {
                var colorName = colorr.Key;
                var clothesDict = colorr.Value;

                Console.WriteLine($"{colorName} clothes:");

                foreach (var clothee in clothesDict)
                {

                    var clotheName = clothee.Key;
                    var value = clothee.Value;


                    if (colorClothing[0].Equals(colorName) && colorClothing[1].Equals(clotheName))
                    {
                        Console.WriteLine($"* {clotheName} - {value} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {clotheName} - {value}");

                    }

                }
            }
        }
    }
}
