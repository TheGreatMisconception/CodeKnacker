using System;

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

        private static int[] GetUserRange(int MinDefault, int MaxDefault) {
            string Min;
            string Max;
            string Input;
            bool Logic;
            Logic = false;

            Console.WriteLine("Do you want to specifiy the number range yourself or use the defaults? (default: [0, 100])\n\nY/n: ");
            Input = Console.ReadLine();

            if (Input.ToLower() == "y") {
                Min = Max = "#";
                if (CanConvert(Min) && CanConvert(Max)) {
                    if (Convert.ToInt32(Min) > Convert.ToInt32(Max)) {
                        Logic = false;
                    }
                    else {
                        Logic = true;
                    }
                }
                while (CanConvert(Min) != true || CanConvert(Max) != true && Logic == false) {
                    Console.WriteLine("1");
                    if (CanConvert(Min) != true)
                    {
                        Console.WriteLine("Min: ");
                        Min = Console.ReadLine();
                    }
                    if (CanConvert(Max) != true)
                    {
                        Console.WriteLine("Max: ");
                        Max = Console.ReadLine();
                    }
                }
                return new int[] { Convert.ToInt32(Min), Convert.ToInt32(Max) };
            }
            else {
                Console.WriteLine("using defaults....\n\n");
                return new int[] { MinDefault, MaxDefault };
            }
        }

        // ##################
        // ##GuessTheNumber##
        // ##################
        // Explanation:
        // You're given a secret number and you have to guess it
        // Try to use as few guesses as possible
        // After each guess you get told if your guess is correct, smaller or greater than the secret number
        private static void GuessTheNumber()
        {
            // Variabal decleration
            Random RND = new Random();
            int Number;
            int IGuess;
            int[] UserRange;
            int UserTries;
            bool Guessed;
            string Guess;
            // Variabal definition
            Guessed = false;
            UserTries = 0;
            // Call GetUserRange Method and pass default range integers to it. If user denies a custom range, these will be used.
            // GetUserRange returns a Interger array which contains a minimum value and a maximum value
            UserRange = GetUserRange(0, 100);
            Number = RND.Next(UserRange[0], UserRange[1]);
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
            Version = "0.7 Variant_7";
            Console.WriteLine("Welcome to CodeKnacker!\nVersion: {0}\n\n", Version);
            // Call Game Method
            GuessTheNumber();
        }
    }
}
