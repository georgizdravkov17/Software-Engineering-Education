using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
   public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reservedTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reservedTeam = new List<Person>();
        }

        public string Name
        {
            get
            {
                return this.Name;
            }
            private set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("Team name must be atleast 3 symbols!");
                }
                this.name = value;
            }
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get
            {
                return this.firstTeam.AsReadOnly();
            }
        }

        public IReadOnlyCollection<Person> ReservedTeam
        {
            get
            {
                return this.reservedTeam.AsReadOnly();
            }
        }

        public void AddPlayer(Person person)
        {
            if(person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reservedTeam.Add(person);
            }
        }

        
    }
}
