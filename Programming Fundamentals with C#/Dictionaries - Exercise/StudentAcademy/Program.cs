using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, double>();

            for (int i = 0; i < rows; i++)
            {
                var studentName = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = grade;
                }
            }

            var sortedStudents = students.Where(g => g.Value >= 4.50);

            foreach (var student in sortedStudents)
            {
                var name = student.Key;
                var grade = student.Value;
                Console.WriteLine($"{name} -> {grade}");
            }
        }
    }
}
