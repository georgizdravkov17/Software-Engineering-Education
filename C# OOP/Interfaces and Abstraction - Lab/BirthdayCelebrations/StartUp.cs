using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Models;

namespace BirthdayCelebrations
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var birthdayCelebrators = new List<ICelebrator>();

            while (true)
            {
                var currentCelebratorArguments = Console.ReadLine().Split().ToArray();

                var command = currentCelebratorArguments[0];
                

                if (command.Equals("End"))
                {
                    break;
                }
                else if (command.Equals("Pet"))
                {
                    var currentCelebratorName = currentCelebratorArguments[1];
                    var birthdate = currentCelebratorArguments[2];

                    var currentPet = new Pet(currentCelebratorName, birthdate);
                    birthdayCelebrators.Add(currentPet);

                }
                else if (command.Equals("Human"))
                {
                    var currentCelebratorName = currentCelebratorArguments[1];
                    var age = int.Parse(currentCelebratorArguments[2]);
                    var id = currentCelebratorArguments[3];
                    var birthdate = currentCelebratorArguments[4];

                    var currentHuman = new Human(currentCelebratorName, age, id, birthdate);

                    birthdayCelebrators.Add(currentHuman);
                }
            }

            var yearOfBirth = Console.ReadLine();

            foreach (var celebrator in birthdayCelebrators.Where(c => c.Birthday.EndsWith(yearOfBirth)))
            {
                Console.WriteLine(celebrator.Birthday);
            }
        }
    }
}
