using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().ToArray();

            var stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
           
        }
    }
}
