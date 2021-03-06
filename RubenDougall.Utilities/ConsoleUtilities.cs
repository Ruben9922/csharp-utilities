﻿using System;

namespace RubenDougall.Utilities
{
    public class ConsoleUtilities
    {
        public static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue, string errorMessage = "Integers only!")
        {
            int result;
            bool inputValid = false;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result) && result >= min && result < max)
                {
                    inputValid = true;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!inputValid);

            return result;
        }
        
        public static double ReadDouble(string prompt, double min = double.MinValue, double max = double.MaxValue, string errorMessage = "Real numbers only!")
        {
            double result;
            bool inputValid = false;
            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result) && result >= min && result < max)
                {
                    inputValid = true;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!inputValid);

            return result;
        }
        
        public static decimal ReadDecimal(string prompt, decimal min = decimal.MinValue, decimal max = decimal.MaxValue, string errorMessage = "Real numbers only!")
        {
            decimal result;
            bool inputValid = false;
            do
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out result) && result >= min && result < max)
                {
                    inputValid = true;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!inputValid);

            return result;
        }

        public static string ReadOptionString(string[] validOptions, string prompt = "Enter option: ")
        {
            string option = "";
            bool inputValid = false;
            while (!inputValid)
            {
                Console.Write(prompt);
                option = Console.ReadLine().ToLower();
                foreach (string validOption in validOptions)
                {
                    if (option == validOption)
                    {
                        inputValid = true;
                        break;
                    }
                }

                if (!inputValid)
                {
                    Console.WriteLine("Invalid option!");
                }
            }

            return option;
        }

        public static int ReadOptionInt(string[] options, string prompt = "Enter option: ")
        {
            int optionCount = options.Length;
            for (int i = 0; i < optionCount; i++)
            {
                Console.WriteLine("  {0}: {1}", i, options[i]);
            }

            int option;
            bool inputValid;
            do
            {
                option = ReadInt(prompt);
                inputValid = option >= 0 && option < optionCount;
                if (!inputValid)
                {
                    Console.WriteLine("Invalid option!");
                }
            } while (!inputValid);

            return option;
        }

        public static bool ReadYOrN(string message = "Try again? (y/n): ")
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input != null && input.ToLower() == "y";
        }
    }
}