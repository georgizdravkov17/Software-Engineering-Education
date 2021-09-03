using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            var result = isInRange(password)
                && isOnlyDigitsAndLetters(password)
                && hasAtleastTwoDigits(password);

            if (result)
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool isInRange(string text)
        {
            var isValid = false;
            var messege = string.Empty;

            if (text.Length >= 6 && text.Length <= 10)
            {
                return isValid = true;
            }
            else
            {

                messege = "Password must be between 6 and 10 characters";
                return isValid;
            }


        }
        public static bool isOnlyDigitsAndLetters(string text)
        {

            var charList = new List<char>();
            var digitList = new List<int>();
            var isValid = false;

            for (int i = 0; i < text.Length; i++)
            {
                var upperLettersCheck = text[i] >= 65 && text[i] <= 90;
                var lowerLettersCheck = text[i] >= 97 && text[i] <= 122;
                var isDigit = int.TryParse(text[i].ToString(), out int currentNumber);
                if (upperLettersCheck || lowerLettersCheck)
                {
                    charList.Add(text[i]);
                }

                else if (isDigit)
                {
                    digitList.Add(currentNumber);
                }
            }

            if (charList.Count + digitList.Count == text.Length)
            {
                isValid = true;
                return isValid;
            }

            else
            {
                Console.WriteLine("Password must consists only digits and letters");
                return isValid;
            }


        }
        public static bool hasAtleastTwoDigits(string text)
        {
            var isValid = false;
            var messege = string.Empty;
            var numbersOfDigits = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var isParsed = int.TryParse(text[i].ToString(), out int result);

                if (isParsed)
                {
                    numbersOfDigits++;
                }
            }

            if (numbersOfDigits >= 2)
            {
                isValid = true;
                return isValid;
            }

            else
            {
                Console.WriteLine("Password must have atleast 2 digits");
                return isValid;
            }

        }
    }
}
