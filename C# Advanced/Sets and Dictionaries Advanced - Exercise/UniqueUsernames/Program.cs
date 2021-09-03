using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesNumber = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (int i = 0; i < namesNumber; i++)
            {
                var currentName = Console.ReadLine();

                names.Add(currentName);
            }


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
