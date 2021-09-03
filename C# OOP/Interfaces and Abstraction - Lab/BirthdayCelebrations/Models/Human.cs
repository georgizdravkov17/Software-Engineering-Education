using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Human : ICelebrator
    {
        public Human(string name,int age,string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthday = birthday;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public string Birthday { get; private set; }

        public override string ToString()
        {
            return $"I am Human {this.Name}, {this.Age} years old with {this.ID} ID and birthdate - {this.Birthday}";
        }
    }
}
