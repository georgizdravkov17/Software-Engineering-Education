using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var typeOfGroup = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if(dayOfWeek == "Friday")
            {
                if(typeOfGroup == "Students")
                {
                    price = 8.45;

                }
                else if (typeOfGroup == "Business")
                {
                    price = 10.90;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 15.60;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 20;
                }
            }
            else if(dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 22.50;
                }
            }

            totalPrice = price * numberOfPeople;


            double discount = 0;

            if(typeOfGroup == "Students" && numberOfPeople >= 30)
            {
                discount = 0.85;
            }
            else if (typeOfGroup == "Business" && numberOfPeople >= 100)
            {
                discount = 0.1;
            }
            else if (typeOfGroup == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                discount = 0.05;
            }

            if(discount != 0)
            {
                totalPrice *= discount;
            }

            
            Console.WriteLine($"Total price: {totalPrice:F2}");



        }
    }
}
