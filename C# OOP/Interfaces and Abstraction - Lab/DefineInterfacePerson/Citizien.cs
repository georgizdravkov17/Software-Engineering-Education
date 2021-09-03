using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineInterfacePerson
{
    public class Citizien : IPerson
    {
        public Citizien(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"- I am {this.Name} - {this.Age} years old.";
        }
    }
}
