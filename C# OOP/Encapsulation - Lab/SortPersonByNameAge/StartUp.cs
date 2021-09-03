using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortPersonByNameAge
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var numbersOfPeopple = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < numbersOfPeopple; i++)
            {
                var currentPersonInfo = Console.ReadLine().Split().ToArray();

                var firstName = currentPersonInfo[0];
                var lastName = currentPersonInfo[1];
                var age = int.Parse(currentPersonInfo[2]);

                var currentPerson = new Person(firstName, lastName, age);

                people.Add(currentPerson);
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
