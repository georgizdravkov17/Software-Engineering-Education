using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            var result = Vowels(input);

            Console.WriteLine(result);
        }

        public static int Vowels(string word)
        {

            var vowels = new char[]
            {
                'a',
                'u',
                'o',
                'y',
                'e',
                'i'
            };

            var counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
