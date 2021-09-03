using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirthdayCelebrations.Interfaces;


namespace BirthdayCelebrations.Models
{
    public class Pet : ICelebrator
    {
        public Pet(string name,string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; private set; }

        public string Birthday { get; private set; }

        public override string ToString()
        {
            return $"I am pet {this.Name} with birthdate {this.Birthday}!";
        }
    }
}
