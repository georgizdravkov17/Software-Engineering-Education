using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinentsAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesNumber = int.Parse(Console.ReadLine());

            var continentsProperties = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            for (int i = 0; i < linesNumber; i++)
            {
                var currentLine = Console.ReadLine().Split().ToArray();
                var continentName = currentLine[0];
                var countryName = currentLine[1];
                var townName = currentLine[2];

                if (!continentsProperties.ContainsKey(continentName))
                {
                    continentsProperties[continentName] = new Dictionary<string, HashSet<string>>();

                }

                if (!continentsProperties[continentName].ContainsKey(countryName))
                {
                    continentsProperties[continentName][continentName] = new HashSet<string>();
                }

                
                    continentsProperties[continentName][countryName].Add(townName);
                
            }

            foreach (var continent in continentsProperties)
            {
                var continentName = continent.Key;
                var countries = continent.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var country in countries)
                {
                    var countryName = country.Key;
                    var towns = country.Value;

                    Console.WriteLine($"{countryName} -> {string.Join(", ",towns)}");
                }
            }
        }
    }
}
