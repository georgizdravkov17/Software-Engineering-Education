using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var registrations = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var currentInfo = Console.ReadLine().Split();
                var command = currentInfo[0];
                var name = currentInfo[1];

                if (command.Equals("register"))
                {
                    var licensePlateNumber = currentInfo[2];

                    if (!registrations.ContainsKey(name))
                    {
                        registrations[name] = licensePlateNumber;
                        Console.WriteLine($"{name} registered {licensePlateNumber} succesfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number: {licensePlateNumber}");
                    }
                }
                else if (command.Equals("unregister"))
                {
                    if (!registrations.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }

                    else
                    {
                        registrations.Remove(name);
                        Console.WriteLine($"{name} unregistered seccesfully");
                    }
                }
            }

            foreach (var user in registrations)
            {
                var name = user.Key;
                var licensePlateNumber = user.Value;
                Console.WriteLine($"{name} => {licensePlateNumber}");
            }
        }
    }
}
