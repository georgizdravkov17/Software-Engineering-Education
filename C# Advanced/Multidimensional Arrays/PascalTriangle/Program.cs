using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var jaggedArray = new int[number][];

            jaggedArray[0] = new int[] { 1 };
            jaggedArray[1] = new int[] { 1, 1 };



            for (int i = 2; i < number; i++)
            {
                jaggedArray[i] = new int[i];
                jaggedArray[i][0] = 1;
                jaggedArray[i][i - 1] = 1;

                for (int k = 1; k < jaggedArray[i].Length - 1; k++)
                {
                    jaggedArray[i][k] = jaggedArray[i - 1][k] + 
                        jaggedArray[i - 1][k - 1];
                }
            }


            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(string.Join(" ",jaggedArray[i]));
            }


            
            
        }
    }
}
