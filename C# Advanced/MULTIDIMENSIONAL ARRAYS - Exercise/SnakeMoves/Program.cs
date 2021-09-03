using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var properties = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var snake = Console.ReadLine();

            var rows = properties[0];
            var cols = properties[1];

            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                }
            }
        }
    }
}
