using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCharacter = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());

            PrintRange(firstCharacter, secondChar);


        }

        public static void PrintRange(char firstChar, char secondChar)
        {
            for (int i = firstChar; i <= secondChar; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
