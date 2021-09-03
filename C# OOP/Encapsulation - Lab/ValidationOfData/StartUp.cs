using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationOfData
{
   public class StartUp
    {
        public static void Main(string[] args)
        {

            try
            {

                var numberOfPeople = int.Parse(Console.ReadLine());

                var persons = new List<Person>();

                for (int i = 0; i < numberOfPeople; i++)
                {
                    var currentPersonInfo = Console.ReadLine().Split().ToArray();

                    var firstName = currentPersonInfo[0];
                    var lastName = currentPersonInfo[1];
                    var age = int.Parse(currentPersonInfo[2]);
                    var salary = decimal.Parse(currentPersonInfo[3]);

                    var currentPerson = new Person(firstName, lastName, age, salary);

                    persons.Add(currentPerson);
                }

                foreach (var person in persons)
                {
                    Console.WriteLine(person.ToString());
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
