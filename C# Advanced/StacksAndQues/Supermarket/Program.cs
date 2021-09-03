using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            var clients = new Queue<string>();

            while (true)
            {
                var currentClient = Console.ReadLine();

                if (currentClient.Equals("Paid"))
                {
                    Console.WriteLine(String.Join("\n",clients));
                    clients.Clear();
                }
                else if (currentClient.Equals("End"))
                {                 
                    break;
                }


                else
                {
                    clients.Enqueue(currentClient);
                }
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
