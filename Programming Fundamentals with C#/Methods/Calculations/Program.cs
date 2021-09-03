using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": Add(firstNumber, secondNumber);break;
                case "multiply": Multiply(firstNumber, secondNumber);break;
                case "devide": Devide(firstNumber, secondNumber);break;
                case "subtract": Subtract(firstNumber, secondNumber);break;
            }

        }

        public static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
        public static void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        public static void Devide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
        public static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
    }
}
