using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorderControl.Interfaces;

namespace BorderControl.Models
{
    public class Citizien : Inhabitant
    {
        public Citizien(string name,int age,string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public override string ToString()
        {
            return $"I am citizien {this.Name}, {this.Age} years old with {this.ID} ID.";
        }
    }
}
