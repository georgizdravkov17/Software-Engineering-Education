using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(SignOfNumber(number));
        }
        public static string SignOfNumber(int number)
        {
            var message = string.Empty;
            if(number > 0)
            {
                message = $"The number {number} is positive.";
            }
            else if (number == 0)
            {
                message = $"The number {number} is zero.";
            }
            else
            {
                message = $"The number {number} is negative.";
            }

            return message;
        }
    }
}
