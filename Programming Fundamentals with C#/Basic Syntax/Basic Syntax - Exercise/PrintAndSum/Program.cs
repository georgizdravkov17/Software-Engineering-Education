using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
