using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorderControl.Models;
using BorderControl.Interfaces;

namespace BorderControl
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            var inhabitants = new List<Inhabitant>();

            while (true)
            {
                var currentInhabitantArguments = Console.ReadLine().Split().ToArray();
                var inhabitantName = currentInhabitantArguments[0];

                if (currentInhabitantArguments[0].Equals("End"))
                {
                    break;
                }

                if(currentInhabitantArguments.Length == 2)
                {
                    var inhabitantID = currentInhabitantArguments[1];

                    var currentHabitant = new Robot(inhabitantName, inhabitantID);

                    inhabitants.Add(currentHabitant);
                }
                else if(currentInhabitantArguments.Length == 3)
                {
                    var inhabitantAge = int.Parse(currentInhabitantArguments[1]);
                    var inhabitantID = currentInhabitantArguments[2];

                    var currentInhabitant = new Citizien(inhabitantName, inhabitantAge, inhabitantID);

                    inhabitants.Add(currentInhabitant);
                }

            }

            var endSymbols = Console.ReadLine();

            foreach (var inhabitant in inhabitants.Where(i => i.ID.EndsWith(endSymbols)))
            {
                Console.WriteLine(inhabitant.ID);
            }
        }
    }
}
