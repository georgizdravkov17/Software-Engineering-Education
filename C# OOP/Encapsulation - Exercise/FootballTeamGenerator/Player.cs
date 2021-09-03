using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
   public class Player : IEnumerable<Player>
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private Player player;

        public Player(string name,int endurance,int sprint,int dribble,int passing,int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty string!");
                }

                this.name = value;
            }
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            set
            {
                ValidateStat(value);

                this.endurance = value;
            }
        }
        

        public int Sprint
        {
            get
            {
                return this.sprint;
            }
           private set
            {
                ValidateStat(value);

                this.endurance = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
          private  set
            {
                ValidateStat(value);

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                ValidateStat(value);

                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }
           private set
            {
                ValidateStat(value);

                this.shooting = value;
            }
        }

        private void ValidateStat(int stat)
        {
            if(stat < 0 && stat <= 100)
            {
                throw new ArgumentException("Stat must be between 0 and 100!");
            }
        }

        public string Stats()
        {
            var stats = $"{this.Name} {this.Endurance} {this.Sprint} {this.Dribble} {this.Passing} {this.Shooting}";

            return stats;
        }

        public int AverageStats()
        {
            var average = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 6;

            return average;
        }

        public IEnumerator<Player> GetEnumerator()
        {                      
                yield return this.player;           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
