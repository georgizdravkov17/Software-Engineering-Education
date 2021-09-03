using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinePerson
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var firstPerson = new Person("Pesho", 20);

            Console.WriteLine(firstPerson.Name);
            Console.WriteLine(firstPerson.Age);

        }
    }
}
