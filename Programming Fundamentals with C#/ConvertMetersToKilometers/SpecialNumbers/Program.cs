using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var delimeter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimeter}{lastName}");
        }
    }
}
