using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrease
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentege)
        {
            if (this.Age >= 30)
            {
                this.Salary += this.Salary * percentege / 100;
            }
            else
            {
                this.Salary += this.Salary * percentege / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - {this.Age} years old, with {this.Salary:F2} salary.";
        }

    }
}