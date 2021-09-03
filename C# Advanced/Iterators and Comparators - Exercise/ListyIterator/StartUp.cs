using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = new ListyIterator();


            while (true)
            {
                var currentLine = Console.ReadLine().Split().ToArray();

                var command = currentLine[0];

                if (command.Equals("END"))
                {
                    break;
                }
                else if (command.Equals("Create"))
                {
                    
                }
                else if (command.Equals("HasNext"))
                {

                }
                else if (command.Equals("Print"))
                {

                }
                else if (command.Equals("Move"))
                {

                }
            }

            
        }
    }
}
