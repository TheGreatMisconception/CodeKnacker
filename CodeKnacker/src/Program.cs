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
            int INumber;
            bool Guessed;
            string Guess;
            Guessed = false;
            Number = 15;
            while (Guessed != true) {
                Console.WriteLine("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    INumber = Convert.ToInt32(Guess);
                    if (Number == INumber) {
                        Console.WriteLine("Congratulations, you guessed the right number\n\nPress any key to exit...");
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else {
                        Console.WriteLine("{0} is not the number you're looking for, try again\n", INumber);
                    
                    }
                }


            }
            return false;
        }

        public static void Main(string[] args)
        {
            string Version;
            Version = "0.1 Variant_1";
            Console.WriteLine("Welcome to CodeKnacker!\nVersion: {0}\n\n", Version);
            GuessTheNumber();
        }
    }
}
