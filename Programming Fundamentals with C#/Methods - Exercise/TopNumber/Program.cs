using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            TopNumber(number);
        }

        public static void TopNumber(int number)
        {
           
            for (int i = 1; i <= number; i++)
            {

                var numberToString = i.ToString();

                var numberSum = 0;

                for (int j = 0; j < numberToString.Length; j++)
                {
                    var numberOfOdds = 0;
                    int currentDigit = int.Parse(numberToString[i].ToString());


                    if (currentDigit % 2 != 0)
                    {
                        numberOfOdds++;
                    }

                    numberSum += currentDigit;

                    if(numberSum % 8 == 0 && numberOfOdds > 0)
                    {
                        Console.WriteLine(i);
                    }


                }

            }



        }
    }
}
