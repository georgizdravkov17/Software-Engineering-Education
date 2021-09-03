using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineInterfacePerson
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var persons = new List<IPerson>();

            var personsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < personsCount; i++)
            {
                var currentPersonArguments = Console.ReadLine().Split().ToArray();

                var currentPersonName = currentPersonArguments[0];
                var currentPersonAge = int.Parse(currentPersonArguments[1]);

                var currentPerson = new Citizien(currentPersonName, currentPersonAge);

                persons.Add(currentPerson);
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
