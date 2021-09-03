using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(numbers);
   

            while (true)
            {
                var line = Console.ReadLine().Split().ToArray();
                var command = line[0].ToLower();
                

                if (command.Equals("end"))
                {
                    break;
                }

                else if (command.Equals("add"))
                {
                    var firstValue = int.Parse(line[1]);
                    var secondValue = int.Parse(line[2]);
                    stack.Push(firstValue);
                    stack.Push(secondValue);
                }

                else if (command.Equals("remove"))
                {
                    var elementToRemove = int.Parse(line[1]);

                    for (int i = 0; i < stack.Count; i++)
                    {
                        var currentElement = stack.Peek();

                        if(currentElement == elementToRemove)
                        {
                            
                        }
                    }
                }

            }

            Console.WriteLine($"Sum: {stack.Sum()}");

            
        }
    }
}
