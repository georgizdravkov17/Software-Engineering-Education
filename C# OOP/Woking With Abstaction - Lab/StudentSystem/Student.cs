using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
   public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private double grade;

        public Student(string firstName,string lastName,int age,double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                ValidateName(value);

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
                ValidateName(value);

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
                if(age <= 0 || age > 100)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.age = value;
            }
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Invalid grade!");
                }

                this.grade = value;
            }
        }

        private void ValidateName(string name)
        {
            if(String.IsNullOrWhiteSpace(name) && name.Length > 15)
            {
                throw new ArgumentException("Invalid name!");
            }
        }

        public override string ToString()
        {
            return $" I am {this.FirstName} {this.LastName}, {this.Age} years old with {this.Grade} grade";
        }
    }
}
