using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            
            var teams = new List<Team>();

            while (true)
            {
                var arguments = Console.ReadLine().Split(';').ToArray();
                var command = arguments[0];
                var teamName = arguments[1];

                if (command.Equals("End"))
                {
                    break;
                }

                else if (command.Equals("Add"))
                {
                    var playerName = arguments[2];
                    var playerEndurance = int.Parse(arguments[3]);
                    var playerSprint = int.Parse(arguments[4]);
                    var playerDribble = int.Parse(arguments[5]);
                    var playerPassing = int.Parse(arguments[6]);
                    var playerShooting = int.Parse(arguments[7]);

                    var team = (Team)teams.Where(t => t.Name.Equals(teamName));

                    if (!teams.Contains(team))
                    {
                        Console.WriteLine($"There is no team {teamName}");
                    }

                    var currentPlayer = new Player(playerName, playerEndurance, playerSprint, playerDribble, 
                        playerPassing, playerShooting);

                    

                    team.AddPlayer(currentPlayer);


                }
                else if (command.Equals("Remove"))
                {
                    var playerName = arguments[2];
                    var team = (Team)teams.Where(t => t.Name.Equals(teamName));

                    var playerToRemove = team.Players.Where(p => p.Name.Equals(playerName));

                    if(teams.Contains(team) && team.ContainsPlayer((Player)playerToRemove))
                    {
                        team.RemovePlayer((Player)playerToRemove);
                    }
                    else
                    {
                        Console.WriteLine($"{team.Name} does not have played {playerName}");
                    }
                    
                  
                }
                else if (command.Equals("Rating"))
                {
                    Team team = (Team)teams.Where(t => t.Name.Equals(teamName));

                    Console.WriteLine($"{teamName} - {team.Rating()}");
                }
                else if (command.Equals("Team"))
                {
                    var currentTeam = new Team(teamName);
                }

            }
        }
    }
}
