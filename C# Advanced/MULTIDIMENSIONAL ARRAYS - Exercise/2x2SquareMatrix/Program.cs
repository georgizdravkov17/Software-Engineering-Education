using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquareMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var properties = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = properties[0];
            var cols = properties[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            var squaresCount = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    bool currentRowCouples = matrix[row,col] == matrix[row,col + 1];
                    bool nextRowCouples = matrix[row + 1, col] == matrix[row + 1, col + 1];
                    if(currentRowCouples && nextRowCouples)
                    {
                        squaresCount++;
                    }
                }
            }

            Console.WriteLine(squaresCount);
        }
    }
}
