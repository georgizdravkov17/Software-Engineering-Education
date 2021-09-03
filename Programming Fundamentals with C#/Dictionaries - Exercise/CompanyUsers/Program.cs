using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            var companyEmployees = new Dictionary<string, List<string>>();

            while (true)
            {
                var currentLine = Console.ReadLine().Split('-');

                if (currentLine[0].Equals("End"))
                {
                    break;
                }

                var companyName = currentLine[0];
                var employeeID = currentLine[1];


                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees[companyName] = new List<string>();
                }

                var values = companyEmployees.Values;

                foreach (var value in values)
                {
                    if (!value.Equals(employeeID))
                    {
                        companyEmployees[companyName].Add(employeeID);
                    }
                    
                }
                            
            }

            foreach (var company in companyEmployees)
            {
                var name = company.Key;
                var employees = company.Value;

                Console.WriteLine(name);
                foreach (var employee in employees)
                {
                    Console.WriteLine($"--{employee}");
                }
            }
        }
    }
}
