using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
   public class Chiken
    {
        private string name;
        private int age;

        public Chiken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name must be atleast 3 symbols");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if(value < 0 || value > 15)
                {
                    throw new ArgumentException("Age must be positive number");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"Chiken {this.Name} ({this.Age} aged) can produce per day!";
        }
    }
}
