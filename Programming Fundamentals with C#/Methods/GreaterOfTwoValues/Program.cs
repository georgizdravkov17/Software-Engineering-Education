using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if(type == "string")
            {
                var firstString = Console.ReadLine();
                var secondString = Console.ReadLine();

                Console.WriteLine(GetMax(firstString,secondString));

                
            }
            else if(type == "char")
            {
                var firstChar = char.Parse(Console.ReadLine());
                var secondChar = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstChar,secondChar));
            }
            else if (type == "int")
            {
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstNumber,secondNumber));
            }
        }

        public static string GetMax(string firstString, string secondString)
        {
            return firstString[0] > secondString[0] ? firstString : secondString;
        }
        public static int GetMax(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }
        public static char GetMax(char firstChar, char secondChar)
        {
            return firstChar > secondChar ? firstChar : secondChar;
        }
    }
}
