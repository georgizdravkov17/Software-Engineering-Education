using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var result = Factorial(firstNumber, secondNumber);

            Console.WriteLine($"{result:F2}");


        }

        public static double Factorial(int firstNumber,int secondNumber)
        {
            var firstNumberFactorial = 1;
            var secondNumberFactorial = 1;

            while(firstNumber > 1)
            {
                firstNumberFactorial *= firstNumber;
                firstNumber--;
            }

            while(secondNumber > 1)
            {
                secondNumberFactorial *= secondNumber;
                secondNumber--;
            }

            var result = firstNumberFactorial / secondNumberFactorial;

            return result;

            
        }
    }
}
