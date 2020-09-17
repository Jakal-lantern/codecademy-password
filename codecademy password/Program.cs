using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            //NOT ORIGINAL CODE USED IN CODECADEMY
            //They used a custom method
            int minLength = 5;
            //string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string lowercase = "abcdefghijklmnopqrstuvwxyz";
            //string digits = "0123456789";
            //string specialChars = "!@#$%^&*()";
            string userInput;
            int score = 0;

            Console.Write("Enter Passord: ");
            userInput = Console.ReadLine();

            if (userInput.Length >= minLength)
            {
                score++;
            }

            if (Regex.IsMatch(userInput, "[A-Z]"))
            {
                score++;
            }

            if (Regex.IsMatch(userInput, "[a-z]"))
            {
                score++;
            }

            if (Regex.IsMatch(userInput, "[0-9]"))
            {
                score++;
            }

            if (Regex.IsMatch(userInput, "[!-*]"))
            {
                score++;
            }

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Extremely Strong");
                    break;
                case 3:
                    Console.WriteLine("Strong");
                    break;
                case 2:
                    Console.WriteLine("Medium");
                    break;
                case 1:
                    Console.WriteLine("Weak");
                    break;
                default:
                    Console.WriteLine("Does not meet standards");
                    break;
            }
        }
    }
}
