using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingConstructors
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            var firstPerson = new Person();

            var secondPerson = new Person(10);

            var thirdPerson = new Person("Gosho", 20);

            persons.Add(firstPerson);
            persons.Add(secondPerson);
            persons.Add(thirdPerson);

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} -> {person.Age}");
            }

        }
    }
}
