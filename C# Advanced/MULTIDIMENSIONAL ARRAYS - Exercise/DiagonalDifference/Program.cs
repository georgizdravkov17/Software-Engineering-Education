using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixPropertyies = int.Parse(Console.ReadLine());

            var matrix = new int[matrixPropertyies, matrixPropertyies];

            for (int row = 0; row < matrixPropertyies; row++)
            {
                var currentMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < currentMatrix.Length; col++)
                {
                    matrix[row, col] = currentMatrix[col];
                }
            }

            var rightDiagonal = 0;
            var leftDiagonal = 0;

            for (int row = 0; row < matrixPropertyies; row++)
            {
                for (int col = 0; col < matrixPropertyies; col++)
                {
                    if(row == col)
                    {
                        rightDiagonal += matrix[row, col];
                    }

                    if(row == matrixPropertyies - col - 1)
                    {
                        leftDiagonal += matrix[row, col];
                    }
                }
            }
     

            var result = Math.Abs(rightDiagonal - leftDiagonal);
            Console.WriteLine(result);

        }
    }
}
