using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var middleElement = MiddleCharacters(input);
            Console.WriteLine(middleElement);
        }

        public static string MiddleCharacters(string text)
        {


            var middleCharacters = String.Empty;

            if (text.Length % 2 != 0)
            {
                middleCharacters = text[text.Length / 2].ToString();

            }

            else
            {
                middleCharacters = text[text.Length / 2 - 1].ToString() + 
                    text[text.Length / 2].ToString();
                
            }

            return middleCharacters;


        }
    }
}
