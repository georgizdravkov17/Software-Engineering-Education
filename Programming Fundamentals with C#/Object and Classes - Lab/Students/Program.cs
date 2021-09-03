using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
       

            var students = new List<Student>();

            while (true)
            {

                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                var splitedCommand = command.Split().ToArray();

                var firstName = splitedCommand[0];
                var lastName = splitedCommand[1];
                var age = int.Parse(splitedCommand[2]);
                var town = splitedCommand[3];

                var currentStudent = new Student(firstName, lastName, age, town);

                students.Add(currentStudent);
    

            }

            var region = Console.ReadLine();

            var filteredStudentList = students.Where(s => s.Town.Equals(region)).ToList();

            foreach (var student in filteredStudentList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }          

        }
    }
}
