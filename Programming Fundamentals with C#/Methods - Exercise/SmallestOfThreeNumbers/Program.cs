using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var smallestNumber = SmallestNumber(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(smallestNumber);
        }

        public static int SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            var smallestNumber = 0;

            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                smallestNumber = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                smallestNumber = secondNumber;
            }
            else
            {
                smallestNumber = thirdNumber;
            }

            return smallestNumber;
        }
    }
}
