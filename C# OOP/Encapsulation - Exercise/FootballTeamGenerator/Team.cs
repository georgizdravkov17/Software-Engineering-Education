using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator 
{
   public class Team : IEnumerable<Team>
    {

        private string name;
        private List<Player> players;
        private Team team;

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }
        public string Name
        {
            get
            {
                return this.Name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team name can not be empty string");
                }

                this.name = value;
            }
        }

        public List<Player> Players
        {
            get
            {
                return this.players;
            } 
            private set
            {
                this.players = value;
            }
        }

        public int Rating()
        {
            var averageTeamStats = 0;

            foreach (var player in players)
            {
                averageTeamStats += player.AverageStats();
            }

            return averageTeamStats;
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            this.Players.Remove(player);
        }

        public bool ContainsPlayer(Player player)
        {
            if (!this.players.Contains(player))
            {
                return false;
            }

            return true;
        }

        public IEnumerator<Team> GetEnumerator()
        {            
                yield return team;          
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
