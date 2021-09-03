using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var result = RepeatedText(input, n);

            Console.WriteLine(result);

        }
        public static string RepeatedText(string text,int n)
        {
            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
