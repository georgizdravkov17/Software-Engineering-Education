using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var currentPersonInfo = Console.ReadLine().Split();

                var personName = currentPersonInfo[0];
                var personAge = int.Parse(currentPersonInfo[1]);

                var person = new Person(personName, personAge);

                people.Add(person);
            }

            var peopleAbove30 = people.Where(p => p.Age > 30).OrderBy(p => p.Name);

            foreach (var person in peopleAbove30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
