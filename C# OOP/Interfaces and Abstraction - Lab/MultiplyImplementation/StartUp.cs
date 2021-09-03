using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyImplementation
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            var persons = new List<Person>();

            var numberOfPersons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPersons; i++)
            {
                var currentPersonArguments = Console.ReadLine().Split().ToArray();

                var currentPersonFirstName = currentPersonArguments[0];
                var currentPersonLastName = currentPersonArguments[1];
                var currentPersonAge = int.Parse(currentPersonArguments[2]);
                var currentPersonID = currentPersonArguments[3];
                var currentPersonDateOfBirth = currentPersonArguments[4];

                var currentPerson = new Person(currentPersonFirstName, currentPersonLastName,
                    currentPersonAge, currentPersonID, currentPersonDateOfBirth);

                persons.Add(currentPerson);
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
