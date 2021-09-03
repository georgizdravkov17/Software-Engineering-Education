using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {

            var boxes = new List<Box>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("end"))
                {
                    break;
                }

                var splitedCommand = command.Split().ToArray();

                var serialNumber = splitedCommand[0];
                var itemName = splitedCommand[1];
                var quantity = int.Parse(splitedCommand[2]);
                var price = double.Parse(splitedCommand[3]);

                Box currentBox = new Box(serialNumber, itemName, quantity, price);
            }
        }
    }
}
