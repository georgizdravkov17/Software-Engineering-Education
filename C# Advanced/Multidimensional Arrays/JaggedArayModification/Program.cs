using System;
using System.Linq;

namespace JaggedArayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var jaggedAray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedAray[row] = currentRow;
            }


            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                
                var row = int.Parse(input[1]);
                var col = int.Parse(input[2]);
                var value = int.Parse(input[3]);


                if (input[0].Equals("end"))
                {
                    break;
                }     
                else if (input[0].Equals("add"))
                {
                    jaggedAray[row][col] += value;
                }
                else if (input[0].Equals("subtract"))
                {
                    jaggedAray[row][col] -= value;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedAray[row]));
            }
        }
    }
}
