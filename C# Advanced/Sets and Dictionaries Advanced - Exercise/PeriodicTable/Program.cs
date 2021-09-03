using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfElements = int.Parse(Console.ReadLine());

            var elements = new HashSet<string>();

            for (int i = 0; i < numberOfElements; i++)
            {
                var currentElement = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < currentElement.Length; j++)
                {
                    elements.Add(currentElement[j]);
                }
            }

            Console.WriteLine(string.Join(" ",elements.OrderBy(e => e)));
        }
    }
}
