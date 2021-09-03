using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models;
using Telephony.Intercases;

namespace Telephony
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            var phones = new List<ICallable>();

            var phoneNumbers = Console.ReadLine().Split().ToArray();

            var urls = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                var currentNumber = phoneNumbers[i];

               if(currentNumber.All(ch => char.IsDigit(ch)))
                {
                    if(currentNumber.Length == 10)
                    {
                        var currentSmarthPhone = new Smartphone(currentNumber);
                        phones.Add(currentSmarthPhone);
                    }
                    else if(currentNumber.Length == 7)
                    {
                        var currentStacionaryPhone = new StacionaryPhone(currentNumber);
                        phones.Add(currentStacionaryPhone);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
            }

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.Call());
            }

            
        }
    }
}
