using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RombusOfStars
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if(n == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                PrintRow(n);
            }
        }

        public static void PrintRow(int n)
        {
           
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    
}
