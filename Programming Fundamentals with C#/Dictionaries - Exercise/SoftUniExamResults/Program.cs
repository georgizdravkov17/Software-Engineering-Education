using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new Dictionary<string, int>();

            var languagesCount = new Dictionary<string, int>();

            while (true)
            {
                var currentLine = Console.ReadLine().Split('-');

                if(currentLine[0].Equals("exam finished"))
                {
                    break;
                }

                var user = currentLine[0];
                var language = currentLine[1];
                var points = int.Parse(currentLine[2]);

                if (!students.ContainsKey(user))
                {
                    students[user] = points;
                }

                if (!languagesCount.ContainsKey(language))
                {
                    languagesCount[language] = 0;
                }

                languagesCount[language]++;


            }

            Console.WriteLine("Results:");

            foreach (var student in students)
            {
                var name = student.Key;
                var points = student.Value;
                Console.WriteLine($"{name} | {points}");

            }

            foreach (var language in languagesCount)
            {
                var languageName = language.Key;
                var languageCount = language.Value;

                Console.WriteLine($"{languageName} - {languageCount}");
            }
        }
    }
}
