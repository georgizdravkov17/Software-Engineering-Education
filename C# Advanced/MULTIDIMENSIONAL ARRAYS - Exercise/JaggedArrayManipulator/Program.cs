using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[row] = currentRow;
            }

            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {

                    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }

                    else
                    {
                        jaggedArray[row][col] /= 2;
                        jaggedArray[row + 1][col] /= 2;
                    }
                }


            }

            

            while (true)
            {
                var arguments = Console.ReadLine().Split().ToArray();
                var command = arguments[0].ToLower();
                var row = int.Parse(arguments[1]);
                var col = int.Parse(arguments[2]);
                var value = int.Parse(arguments[3]);




                if (command.Equals("end"))
                {
                    break;
                }


                else if (command.Equals("add"))
                {

                    if ((row >= 0 && row < rows) || (col >= 0 && col >= jaggedArray[row].Length))
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid row or col!");
                    }
                }
                else if (command.Equals("subtract"))
                {
                    if ((row >= 0 && row < rows) || (col >= 0 && col >= jaggedArray[row].Length))
                    {
                        jaggedArray[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid row or col!");
                    }
                }
            }

            for (int currentRow = 0; currentRow < jaggedArray.Length; currentRow++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[currentRow]));
            }
        }
    }
}
