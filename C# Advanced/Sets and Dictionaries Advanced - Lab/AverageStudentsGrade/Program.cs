using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentsGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < studentsCount; i++)
            {
                var currentStudent = Console.ReadLine().Split().ToArray();

                var studentName = currentStudent[0];
                var studentGrade = double.Parse(currentStudent[1]);

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                var key = student.Key;
                var grades = student.Value;

                Console.Write(key + " -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {grades.Average():F2})");
            }
        }
    }
}
