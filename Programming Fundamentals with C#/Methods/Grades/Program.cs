using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            var result = PrintGrade(grade);

            Console.WriteLine(result);
        }
        public static string PrintGrade(double grade)
        {
            var messege = string.Empty;

            if(grade >= 2.00 && grade <= 2.99)
            {
                messege = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                messege = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                messege = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                messege = "Very good";
            }

            else
            {
                messege = "Excellent";
            }

            return messege;
        }
    }
}
