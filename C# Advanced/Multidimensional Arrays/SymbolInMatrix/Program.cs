using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                var currentRow = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            var symbol = char.Parse(Console.ReadLine());

            var foundRow = 0;
            var foundCol = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    var currentItem = matrix[row, col];

                    if (currentItem == symbol)
                    {
                        foundRow = row;
                        foundCol = col;
                        break;
                        
                    }
                }
            }

            if(foundRow != 0 && foundCol != 0)
            {
                Console.WriteLine($"({foundRow}, {foundCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}