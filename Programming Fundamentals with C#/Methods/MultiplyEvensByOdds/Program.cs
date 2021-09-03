using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            GetMultiplyOfEvenAndOdds(number);
        }

        public static int GetSumOfEvenDigits(int number)
        {
            var numberOfRotations = number.ToString().Length;
            var sumOfEven = 0;
            while(numberOfRotations > 0)
            {
                var currentNumber = number % 10;
                if(currentNumber % 2 == 0)
                {
                    sumOfEven += currentNumber;
                }

                numberOfRotations--;
            }

            return sumOfEven;
        }
        public static int GetSumOfOddDigits(int number)
        {

            var numberOfRotations = number.ToString().Length;
            var sumOfOdd = 0;
            while (numberOfRotations > 0)
            {
                var currentNumber = number % 10;
                if (currentNumber % 2 != 0)
                {
                    sumOfOdd += currentNumber;
                }

                numberOfRotations--;
            }

            return sumOfOdd;

        }
        public static void GetMultiplyOfEvenAndOdds(int number)
        {
            var result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            Console.WriteLine(result);
        }
    }


}


