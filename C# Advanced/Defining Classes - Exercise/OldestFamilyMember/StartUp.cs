using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            

            var family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var currentPersonInfo = Console.ReadLine().Split().ToArray();
                var currentPersonName = currentPersonInfo[0];
                var currentPersonAge = int.Parse(currentPersonInfo[1]);

                var currentPerson = new Person(currentPersonName, currentPersonAge);

                family.addMember(currentPerson);
                
            }

            Person oldestPerson = family.GetOldestPerson();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

            
        }
    }
}
