using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var numberOfPlayers = int.Parse(Console.ReadLine());

            var team = new Team("Levski");

            for (int i = 0; i < numberOfPlayers; i++)
            {
                var currentPlayerInfo = Console.ReadLine().Split().ToArray();

                var firstName = currentPlayerInfo[0];
                var lastName = currentPlayerInfo[1];
                var age = int.Parse(currentPlayerInfo[2]);
                var salary = decimal.Parse(currentPlayerInfo[3]);

                var currentPlayer = new Person(firstName, lastName, age, salary);

                team.AddPlayer(currentPlayer);
            }

            Console.WriteLine($"First Team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"First Team has {team.ReservedTeam.Count} players.");
        }
    }
}
