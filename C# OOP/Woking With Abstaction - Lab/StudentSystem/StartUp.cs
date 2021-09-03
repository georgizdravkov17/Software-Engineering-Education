using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
   public class StartUp
    {
       public static void Main(string[] args)
        {

            var students = new List<Student>();

            while (true)
            {
                var arguments = Console.ReadLine().Split().ToArray();
                var command = arguments[0];

                if (command.Equals("Exit"))
                {
                    break;
                }

                else if (command.Equals("Create"))
                {
                    var studentFirstName = arguments[1];
                    var studentLastName = arguments[2];
                    var studentAge = int.Parse(arguments[3]);
                    var studentGrade = double.Parse(arguments[4]);

                    var currentStudent = new Student(studentFirstName, studentLastName, studentAge, studentGrade);

                    students.Add(currentStudent);
                }

                else if (command.Equals("Show"))
                {
                    var studentName = arguments[1];
                    foreach (var student in students)
                    {
                        if (student.FirstName.Equals(studentName))
                        {
                            Console.WriteLine(student.ToString());
                        }
                    }
                }
            }
        }
    }
}
