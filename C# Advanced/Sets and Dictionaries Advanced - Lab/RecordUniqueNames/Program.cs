using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNames = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (int i = 0; i < numberOfNames; i++)
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
