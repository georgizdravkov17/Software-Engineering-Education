using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split().ToArray();
            var secondArray = Console.ReadLine().Split().ToArray();
            

            for (int i = 0; i < firstArray.Length; i++)
            {
                var currentWord = firstArray[i];
                if (secondArray.Contains(currentWord))
                {
                    Console.Write($"{currentWord} ");
                }
            }
        }
    }
}
