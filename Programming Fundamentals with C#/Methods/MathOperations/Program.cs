using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var opr = Console.ReadLine();
            var secondNumber = int.Parse(Console.ReadLine());

            var result = MathOperation(firstNumber, opr, secondNumber);

            Console.WriteLine(result);
        }

        public static int MathOperation(int firstNumber,string opr, int secondNumber)
        {
            var result = 0;
            switch (opr)
            {
                case "+": result = firstNumber + secondNumber;break;
                case "-": result = firstNumber - secondNumber;break;
                case "*": result = firstNumber * secondNumber;break;
                case "/": result = firstNumber / secondNumber;break;
            }

            return result;
        }
    }
}
