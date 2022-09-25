﻿using System;

namespace CodeKnacker
{
    class MainClass
    {
        // Check if a input string can be converted into an integer by using a try/catch statement
        private static bool CanConvert(string num)
        { 
        int CNum;
            try { 
                CNum = Convert.ToInt32(num);
            }
            catch {
                return false;
            }
            return true;
        }


        // GuessTheNumber
        // You're given a secret number and you have to guess it
        // Try to use as few guesses as possible
        // After each guess you get told if your guess is correct, smaller or greater than the secret number
        private static void GuessTheNumber()
        {
            // Variabal decleration
            Random RND = new Random();
            int Number;
            int IGuess;
            int UserTries;
            bool Guessed;
            string Guess;
            // Variabal definition
            Guessed = false;
            UserTries = 0;
            // By using % we can specify the range of random numbers.
            // That works by getting the remainder of a division.
            // % 1001 would therefore cover the range 1 to 1000
            Number = RND.Next() % 1001;
            Console.WriteLine(Number);

            // Logic
            while (Guessed != true) {
                Console.WriteLine("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    UserTries += 1;
                    if (Number == IGuess) {
                        Console.WriteLine("Congratulations, you guessed the right number ({0} Attempts)\n\nPress any key to exit...", UserTries);
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else {
                        if (IGuess > Number)
                        {
                            Console.WriteLine("{0} is greater than the number you're looking for, try again\n", IGuess);

                        }
                        else {
                            Console.WriteLine("{0} is smaller than the number you're looking for, try again\n", IGuess);
                        }

                    }
                }


            }
        }

        public static void Main(string[] args)
        {
            string Version;
            Version = "0.5 Variant_5 (unbeatable)";
            Console.WriteLine("Welcome to CodeKnacker!\nVersion: {0}\n\n", Version);
            // Call Game Method
            GuessTheNumber();
        }
    }
}
