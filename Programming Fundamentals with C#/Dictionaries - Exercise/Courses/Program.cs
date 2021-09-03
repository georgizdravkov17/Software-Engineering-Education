using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<String>>();

            while (true)
            {
                var currentLine = Console.ReadLine().Split(':');

                if (currentLine[0].Equals("end"))
                {
                    break;
                }

                var courseName = currentLine[0];
                var studentName = currentLine[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);
        
            }

            foreach (var course in courses)
            {
                var courseName = course.Key;
                var students = course.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"--{student}");
                }
            }
        }
    }
}
