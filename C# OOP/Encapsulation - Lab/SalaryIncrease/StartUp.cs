using System;
using System.Collections.Generic;
using System.Linq;

namespace SalaryIncrease
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var currentPersonInfo = Console.ReadLine().Split().ToArray();

                var firstName = currentPersonInfo[0];
                var lastName = currentPersonInfo[1];
                var age = int.Parse(currentPersonInfo[2]);
                var salary = decimal.Parse(currentPersonInfo[3]);

                var currentPerson = new Person(firstName, lastName, age, salary);

                people.Add(currentPerson);

            }

            var percentege = decimal.Parse(Console.ReadLine());

            foreach (var person in people)
            {
                person.IncreaseSalary(percentege);
                Console.WriteLine(person.ToString());

            }
        }
    }
}
