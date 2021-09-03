using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            

            if(numbers.Length <= 3)
            {
                Console.WriteLine(string.Join(" ",numbers.OrderBy(n => n).Reverse()));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.OrderBy(n => n).Reverse().Take(3)));
            }
        }
    }
}
