using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShortage.Models;
using FoodShortage.Interfaces;

namespace FoodShortage
{
   public class StartUp
    {
      public static void Main(string[] args)
        {
            var persons = new List<IBuyer>();

            var numberOfPersons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPersons; i++)
            {
                var currentPersonArguments = Console.ReadLine().Split().ToArray();

                var currentPersonName = currentPersonArguments[0];
                var currentPersonAge = int.Parse(currentPersonArguments[1]);

                var containsNameCheck = persons.Any(p => p.Name.Equals(currentPersonName));

                if(currentPersonArguments.Length == 4 && !containsNameCheck)
                {
                    var currentCitizienID = currentPersonArguments[2];
                    var currentCitizienBirthdate = currentPersonArguments[3];

                    var currentCitizien = new Citizen(currentPersonName, currentPersonAge, currentCitizienID, currentCitizienBirthdate);
                    persons.Add(currentCitizien);
                }
                else if(currentPersonArguments.Length == 3 && !containsNameCheck)
                {
                    var currentRebelGroup = currentPersonArguments[2];

                    var currentRebel = new Rebel(currentPersonName, currentPersonAge, currentRebelGroup);

                    persons.Add(currentRebel);
                }
            }

            var totalAmount = 0;

            while (true)
            {
                var buyerName = Console.ReadLine();

                if (buyerName.Equals("End"))
                {
                    break;
                }

                foreach (var person in persons)
                {
                    if (person.Name.Equals(buyerName))
                    {
                       totalAmount += person.BuyFood();
                    }
                }               
            }

            Console.WriteLine(totalAmount);
        }
    }
}
