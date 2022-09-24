using System;

namespace CodeKnacker
{
    class MainClass
    {
        // Check if a input string can be converter into an integer by using a try/catch statement
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
        // After each guess you get told if you guess is correct, smaller or greater than the secret number
        private static bool GuessTheNumber()
        {
            int Number;
            int IGuess;
            int UserTries;
            bool Guessed;
            string Guess;
            Guessed = false;
            UserTries = 0;
            Number = 15;

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
            return false;
        }

        public static void Main(string[] args)
        {
            // Variant_3's Instructions already used in Variant_1 and Variant_2
            string Version;
            Version = "0.2 Variant_2";
            Console.WriteLine("Welcome to CodeKnacker!\nVersion: {0}\n\n", Version);
            GuessTheNumber();
        }
    }
}
