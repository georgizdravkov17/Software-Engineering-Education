using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservations = new HashSet<string>();

            var vipGuests = new HashSet<string>();

            var notCameGuests = new HashSet<string>();

            while (true)
            {
                var currentNumber = Console.ReadLine();

                if (currentNumber.Equals("END"))
                {
                    break;
                }

                else if (currentNumber == "PARTY")
                {
                    while (true)
                    {
                        var currentGuest = Console.ReadLine();

                        if (currentNumber.Equals("END"))
                        {
                            break;
                        }

                        if (!reservations.Contains(currentGuest) && !vipGuests.Contains(currentGuest))
                        {
                            notCameGuests.Add(currentGuest);
                        }
                    }

                    break;
                }

                else
                {
                    bool isDigit = char.IsDigit(currentNumber[0]);

                    if (isDigit)
                    {
                        vipGuests.Add(currentNumber);
                    }
                    else if (!isDigit && currentNumber.Length == 8)
                    {
                        reservations.Add(currentNumber);
                    }

                }

            }

            Console.WriteLine(notCameGuests.Count);
            foreach (var guest in notCameGuests)
            {
                Console.WriteLine(guest);
            }


        }
    }
}
