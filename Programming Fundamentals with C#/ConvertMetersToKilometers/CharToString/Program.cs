using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = Console.ReadLine();
            var secondChar = Console.ReadLine();
            var thirdChar = Console.ReadLine();

            var resultString = String.Empty;

            resultString = firstChar + secondChar + thirdChar;

            Console.WriteLine(resultString);
        }
    }
}
