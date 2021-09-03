using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());


        }

        public static int Sum(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;

            return result;
        }

        public static int Subtract(int thirdNumber)
        {
            var substractResult = Sum() - thirdNumber;

            return substractResult;
        }
    }
}
