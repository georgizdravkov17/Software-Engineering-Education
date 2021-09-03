using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {',',' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = input[0];
            var cols = input[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentArray[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                var sum = 0;

                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row,col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
