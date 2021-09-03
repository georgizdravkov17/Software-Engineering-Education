using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuflling
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

            while (true)
            {
                var currentLine = Console.ReadLine().Split().ToArray();

                var command = currentLine[0].ToLower();

                if (command.Equals("end"))
                {
                    break;
                }

                else if (command.Equals("swap"))
                {


                    var row1 = int.Parse(currentLine[1]);
                    var col1 = int.Parse(currentLine[2]);
                    var row2 = int.Parse(currentLine[3]);
                    var col2 = int.Parse(currentLine[4]);

                    if (row1 >= rows || row2 >= rows || col1 >= cols || col2 >= cols)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        var firstItem = matrix[row1, col1];
                        var secondItem = matrix[row2, col2];

                        matrix[row1, col1] = secondItem;
                        matrix[row2, col2] = firstItem;
                    }

                }
 
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
