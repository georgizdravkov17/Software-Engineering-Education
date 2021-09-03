using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var result = PowerNumber(number, power);

            Console.WriteLine(result);
        }
        public static int PowerNumber(int number,int power)
        {
            var poweredNumber = 1;

            for (int i = 0; i < power; i++)
            {
                poweredNumber *= number;
            }

            return poweredNumber;
        }
    }
}
