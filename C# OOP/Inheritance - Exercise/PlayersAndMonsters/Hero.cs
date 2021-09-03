using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Hero
    {
        public Hero(string userName,int level)
        {
            this.UserName = userName;
            this.Level = level;
        }

        public string UserName { get; private set; }

        public int Level { get; private set; }

        public override string ToString()
        {
            return $"Username: {this.UserName}, Level: {this.Level}";
        }
    }

    
}
