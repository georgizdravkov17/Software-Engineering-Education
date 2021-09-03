using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
   public class Family
    {

        private List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }

        public List<Person> People
        {
            get
            {
                return this.people;
            }
            set
            {
                this.people = value;
            }
        }

        public void addMember(Person person)
        {
            people.Add(person);
        }

        public Person GetOldestPerson()
        {
            var oldestPerson = this.people.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldestPerson;
        }

        


    }
}
