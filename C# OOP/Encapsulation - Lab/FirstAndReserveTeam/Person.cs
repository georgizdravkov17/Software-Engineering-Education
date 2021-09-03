using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName,string lastName,int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("First Name must be atleast 3 symbols");
                }

                this.firstName = value;
            }

        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
           private set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("Last Name must be atleast 3 symbols");
                }

                this.lastName = value;
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
                if(value <= 0)
                {
                    throw new ArgumentException("Age must be positive number!");
                }

                this.age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if(value < 460)
                {
                    throw new ArgumentException("Salary must be minimum 460 leva!");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - {this.Age} years old, with {this.Salary} salary.";
        }
    }
}
