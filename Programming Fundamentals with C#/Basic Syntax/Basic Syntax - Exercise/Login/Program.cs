using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            var rightPassword = string.Empty;



            for (int i = username.Length - 1; i >= 0; i--)
            {
                rightPassword += username[i];
            }

            var counter = 0;

            while (true)
            {
                if (password.Equals(rightPassword))
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }

                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    password = Console.ReadLine();
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                   
                }
            }




        }
    }
}
