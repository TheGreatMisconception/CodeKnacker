using System;

namespace CodeKnacker
{
    class MainClass
    {
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

        private static bool GuessTheNumber()
        {
            int Number;
            int IGuess;
            bool Guessed;
            string Guess;
            Guessed = false;
            Number = 15;
            while (Guessed != true) {
                Console.WriteLine("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    if (Number == IGuess) {
                        Console.WriteLine("Congratulations, you guessed the right number\n\nPress any key to exit...");
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
            string Version;
            Version = "0.2 Variant_2";
            Console.WriteLine("Welcome to CodeKnacker!\nVersion: {0}\n\n", Version);
            GuessTheNumber();
        }
    }
}
