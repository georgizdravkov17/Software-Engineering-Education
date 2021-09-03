using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyImplementation
{
    public class Person : IPerson, IIdentifiable, IBirthable
    {
        public Person(string firstName,string lastName,int age, string id, string dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.ID = id;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public string DateOfBirth { get; private set; }

        public override string ToString()
        {
            var personInfo = $"{this.FirstName} {this.LastName} {this.Age} {this.ID} {this.DateOfBirth}";

            return personInfo;
        }
    }
}
