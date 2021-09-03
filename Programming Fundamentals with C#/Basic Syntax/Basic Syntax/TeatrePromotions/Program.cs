using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var personAge = int.Parse(Console.ReadLine());

            double price = 0;

            if(personAge >= 0 && personAge <= 18)
            {
                if(day == "Weekday")
                {
                    price = 12;
                }

                else if (day == "Weekend")
                {
                    price = 18;
                }

                else if (day == "Holiday")
                {
                    price = 12;
                }
            }
            else if (personAge >= 18 && personAge <= 64)
            {
                if (day == "Weekday")
                {
                    price = 15;
                }

                else if (day == "Weekend")
                {
                    price = 20;
                }

                else if (day == "Holiday")
                {
                    price = 15;
                }
            }
            else if (personAge > 64 && personAge <= 122)
            {
                if (day == "Weekday")
                {
                    price = 5;
                }

                else if (day == "Weekend")
                {
                    price = 12;
                }

                else if (day == "Holiday")
                {
                    price = 10;
                }
            }

            else
            {
                Console.WriteLine("Error!");
            }

            Console.WriteLine($"{price}$");
        }
    }
}
