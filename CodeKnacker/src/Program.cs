using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKnacker
{
    internal class Program
    {

        private static bool CanConvert(string num)
        {
            try
            {
                Convert.ToInt32(num);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static void Variant1()
        {
            int SecretNumber;
            string Guess;
            SecretNumber = 15;
            Console.Write("Enter Number: ");
            Guess = Console.ReadLine();
            if (CanConvert(Guess))
            {
                if (Convert.ToInt32(Guess) == SecretNumber) { Console.WriteLine("Congratulations, you guessed the right number!"); }
                else { Console.WriteLine("{0} is not the number you're looking for.", Convert.ToInt32(Guess)); }
            }
            else
            {
                Console.WriteLine("{0} is not a valid number.", Guess);
            }
            Console.WriteLine("\n\nExiting Variant 1..\n");
        }


        private static void Variant2()
        {
            int SecretNumber;
            string Guess;
            SecretNumber = 15;
            Console.Write("Enter Number: ");
            Guess = Console.ReadLine();
            if (CanConvert(Guess))
            {
                if (Convert.ToInt32(Guess) == SecretNumber) { Console.WriteLine("Congratulations, you guessed the right number!"); }
                else if (Convert.ToInt32(Guess) < SecretNumber) { Console.WriteLine("{0} is smaller than the number you're looking for.", Convert.ToInt32(Guess)); }
                else if (Convert.ToInt32(Guess) > SecretNumber) { Console.WriteLine("{0} is greater than the number you're looking for.", Convert.ToInt32(Guess)); }
            }
            else
            {
                Console.WriteLine("{0} is not a valid number.", Guess);
            }
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }


        private static void Variant3()
        {
            int Number;
            int IGuess;
            bool Guessed;
            string Guess;
            Guessed = false;
            Number = 15;
            while (Guessed != true)
            {
                Console.Write("\nEnter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    if (Number == IGuess)
                    {
                        Console.WriteLine("Congratulations, you guessed the right number\n\nPress any key to exit...");
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else if (IGuess > Number)
                    {
                        Console.WriteLine("{0} is greater than the number you're looking for, try again", IGuess);
                    }
                    else
                    {
                        Console.WriteLine("{0} is smaller than the number you're looking for, try again", IGuess);
                    }
                }
            }
        }


        private static void Variant4()
        {
            int Number;
            int IGuess;
            int UserTries;
            bool Guessed;
            string Guess;
            Guessed = false;
            UserTries = 0;
            Number = 15;

            while (Guessed != true)
            {
                Console.Write("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    UserTries += 1;
                    if (Number == IGuess)
                    {
                        Console.WriteLine("Congratulations, you guessed the right number ({0} Attempts)\n\nPress any key to exit...", UserTries);
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else
                    {
                        if (IGuess > Number)
                        {
                            Console.WriteLine("{0} is greater than the number you're looking for, try again\n", IGuess);
                        }
                        else
                        {
                            Console.WriteLine("{0} is smaller than the number you're looking for, try again\n", IGuess);
                        }
                    }
                }
            }
        }


        private static void Variant5()
        {
            Random RND = new Random();
            int Number;
            int IGuess;
            int UserTries;
            bool Guessed;
            string Guess;
            Guessed = false;
            UserTries = 0;
            // Generates a "random" number from 0 to 2147483647 (Impossible to Guess)
            Number = RND.Next();

            while (Guessed != true)
            {
                Console.Write("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    UserTries += 1;
                    if (Number == IGuess)
                    {
                        Console.WriteLine("Congratulations, you guessed the right number ({0} Attempts)\n\nPress any key to exit...", UserTries);
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else
                    {
                        if (IGuess > Number)
                        {
                            Console.WriteLine("{0} is greater than the number you're looking for, try again\n", IGuess);
                        }
                        else
                        {
                            Console.WriteLine("{0} is smaller than the number you're looking for, try again\n", IGuess);
                        }
                    }
                }
            }
        }


        private static void Variant6()
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
            // % 1001 would therefore cover the range 0 to 1000
            // % 1000 would only cover 0 to 999
            // In order to increase the minimum value, we just need to add the wanted minimum value to the to the remainder.
            // Keep in mind that your maximum value increases by the same amount as well.
            // Example: (RND.Next % 101) + 100 would correspond to the following range: 100 -> 200
            Number = RND.Next() % 1001;
            Console.WriteLine(Number);

            // Logic
            while (Guessed != true)
            {
                Console.Write("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    UserTries += 1;
                    if (Number == IGuess)
                    {
                        Console.WriteLine("Congratulations, you guessed the right number ({0} Attempts)\n\nPress any key to exit...", UserTries);
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else
                    {
                        if (IGuess > Number)
                        {
                            Console.WriteLine("{0} is greater than the number you're looking for, try again\n", IGuess);
                        }
                        else
                        {
                            Console.WriteLine("{0} is smaller than the number you're looking for, try again\n", IGuess);
                        }
                    }
                }
            }
        }

        private static int[] GetUserRange(int MinDefault, int MaxDefault)
        {
            string Min;
            string Max;
            string Input;
            bool Logic;
            Logic = false;

            Console.Write("Do you want to specifiy the number range yourself or use the defaults? (default: [{0}, {1}])\n\nY/n: ", MinDefault, MaxDefault);
            Input = Console.ReadLine();

            if (Input.ToLower() == "y")
            {
                Min = Max = "#";
                if (CanConvert(Min) && CanConvert(Max))
                {
                    if (Convert.ToInt32(Min) > Convert.ToInt32(Max))
                    {
                        Logic = false;
                    }
                    else
                    {
                        Logic = true;
                    }
                }
                while (CanConvert(Min) != true || CanConvert(Max) != true && Logic == false)
                {
                    if (CanConvert(Min) != true)
                    {
                        Console.Write("Min: ");
                        Min = Console.ReadLine();
                    }
                    if (CanConvert(Max) != true)
                    {
                        Console.Write("Max: ");
                        Max = Console.ReadLine();
                    }
                }
                return new int[] { Convert.ToInt32(Min), Convert.ToInt32(Max), 1 };
            }
            else
            {
                Console.WriteLine("using defaults....\n\n");
                return new int[] { MinDefault, MaxDefault, 0 };
            }
        }

        private static void Variant7()
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
            while (Guessed != true)
            {
                Console.Write("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    UserTries += 1;
                    if (Number == IGuess)
                    {
                        Console.WriteLine("Congratulations, you guessed the right number ({0} Attempts)\n\nPress any key to exit...", UserTries);
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else
                    {
                        if (IGuess > Number)
                        {
                            Console.WriteLine("{0} is greater than the number you're looking for, try again\n", IGuess);
                        }
                        else
                        {
                            Console.WriteLine("{0} is smaller than the number you're looking for, try again\n", IGuess);
                        }
                    }
                }
            }
        }

        private static void Variant8()
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
            UserRange = GetUserRange(1000, 10000);
            Number = RND.Next(UserRange[0], UserRange[1]);
            // Logic
            while (Guessed != true)
            {
                Console.Write("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    UserTries += 1;
                    if (Number == IGuess)
                    {
                        if (UserRange[2] == 0 && UserTries == 14)
                        {
                            Console.WriteLine("Congratulations, you guessed the right number and scored average({0} Attempts)\n\nPress any key to exit...", UserTries);
                        }
                        else if (UserRange[2] == 0 && UserTries < 14)
                        {
                            Console.WriteLine("Congratulations, you guessed the right number and scored better than average({0} Attempts)\n\nPress any key to exit...", UserTries);
                        }
                        else if (UserRange[2] == 0 && UserTries > 14)
                        {
                            Console.WriteLine("Congratulations, you guessed the right number and scored worse than average({0} Attempts)\n\nPress any key to exit...", UserTries);
                        }
                        else
                        {
                            Console.WriteLine("Congratulations, you guessed the right number.({0} Attempts)\n\nPress any key to exit...", UserTries);
                        }
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else
                    {
                        if (IGuess > Number)
                        {
                            Console.WriteLine("{0} is greater than the number you're looking for, try again\n", IGuess);
                        }
                        else
                        {
                            Console.WriteLine("{0} is smaller than the number you're looking for, try again\n", IGuess);
                        }
                    }
                }
            }
        }

        private static string CalcScore(int[] Range, int Attempts)
        {
            int AverageScore;
            AverageScore = Convert.ToInt32(Math.Round(Math.Log(Range[1] - Range[0]) / Math.Log(2)));
            if (Attempts > AverageScore)
            {
                return "You scored worse than the average person!";
            }
            else if (Attempts < AverageScore)
            {
                return $"Woah, you scored better than the average person by only using {Attempts}";
            }
            else
            {
                return "You scored average";
            }
        }

        private static void Variant9()
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
            while (Guessed != true)
            {
                Console.Write("Enter number: ");
                Guess = Console.ReadLine();
                if (CanConvert(Guess))
                {
                    IGuess = Convert.ToInt32(Guess);
                    UserTries += 1;
                    if (Number == IGuess)
                    {
                        Console.WriteLine("Congratulations, you guessed the right number.{0}\n\nPress any key to exit...", CalcScore(UserRange, UserTries));
                        Console.ReadKey();
                        Guessed = true;
                    }
                    else
                    {
                        if (IGuess > Number)
                        {
                            Console.WriteLine("{0} is greater than the number you're looking for, try again\n", IGuess);
                        }
                        else
                        {
                            Console.WriteLine("{0} is smaller than the number you're looking for, try again\n", IGuess);
                        }
                    }
                }
            }
        }

        private static int[] GetUserNumber()
        {
            string RangeMin;
            string RangeMax;
            bool CorrectInput;
            CorrectInput = false;
            RangeMin = RangeMax = "!"; // shitty ide doesnt recognize variable definition within while loop
            while (CorrectInput != true)
            {
                Console.Write("minimum range in which the number is present:");
                RangeMin = Console.ReadLine();
                Console.Write("maximum range in which the number is present:");
                RangeMax = Console.ReadLine();

                if (CanConvert(RangeMin) && CanConvert(RangeMax))
                {
                    CorrectInput = true;
                }
            }
            return new int[] { Convert.ToInt32(RangeMin), Convert.ToInt32(RangeMax) };
        }

        private static void IGuessTheNumber()
        {
            int[] MyRange;
            var RND = new Random();
            int Random;
            string Input;
            bool Guessed;
            Input = "!";
            Guessed = false;
            MyRange = GetUserNumber();
            while (Guessed != true)
            {
                Random = RND.Next(MyRange[0], MyRange[1]);
                Console.Write($"[{Random}]  =/l/g/>");
                Input = Console.ReadLine();
                if (Input == "g")
                {
                    MyRange[1] = Random;
                }
                else if (Input == "l")
                {
                    MyRange[2] = Random;
                }
                else if (Input == "=")
                {
                    Console.WriteLine("\nEye, Eye Sir\n\nPress any key to exit....");
                    Console.ReadKey();
                    Guessed = true;
                }
            }
        }


        private static void NewNumbers()
        {
            Random RND = new Random();
            Console.WriteLine("2x 32bit random numbers concatinated\n");
            for (int i = 0; i < 201; i++)
            {
                Console.WriteLine($"{RND.Next(0, 900000)}{RND.Next(0, 900000)}");
            }
            for (int i = 0; i < 201; i++)
            {
                Console.WriteLine();
            }


        }

        // TODO
        /*
            - Implement Shell parameters
            - clean up code
         */
        static void Main(string[] args)
        {
            bool Exit;
            string[] Variants = { "Hardcoded Secretnumber", "Computer Feedback: smaller or greater", "Interactive Respones", "Computer Feedback: Attempts", "Random Generated Secretnumber", "Limited Random Number from 1000 to 10000", "User Specifed Range", "Computer Feedback: Hardcoded Good, Bad, Average", "Computer Feedback: logarithm", "Computer Guesses the Number", "Shows Random Number thats is greater than 10.000.000.000" };
            Exit = false;
            string HelpCommand = $"Welcome to CodeKnacker!\n\nOptions:\nd = display all variants and its description\nx = Variant  (x is the name of the variant)\n! = exit the program\n? = This help message\nsource = displays url to source\nclrs = clear the screen by 150 lines\n";
            Console.WriteLine(HelpCommand);
            while (Exit != true)
            {
                string Input;
                Console.Write(">");
                Input = Console.ReadLine();
                if (Input == "!") { Exit = true; }
                else if (Input == "?") { Console.WriteLine(HelpCommand); }
                else if (Input == "d")
                {
                    Console.WriteLine("IndexName    Description\n");
                    for (int i = 0; i < Variants.Length; i++)
                    {
                        if (i > 8) { Console.WriteLine($"{i + 1}           {Variants[i]}"); }
                        else { Console.WriteLine($"{i + 1}            {Variants[i]}"); }
                    }
                    Console.WriteLine("\n");
                }
                else if (CanConvert(Input) && Convert.ToInt32(Input) >= 1 && Convert.ToInt32(Input) <= 11)
                {
                    int GameVariant;
                    GameVariant = Convert.ToInt32(Input);
                    if (GameVariant == 1) { Variant1(); }
                    else if (GameVariant == 2) { Variant2(); }
                    else if (GameVariant == 3) { Variant3(); }
                    else if (GameVariant == 4) { Variant4(); }
                    else if (GameVariant == 5) { Variant5(); }
                    else if (GameVariant == 6) { Variant6(); }
                    else if (GameVariant == 7) { Variant7(); }
                    else if (GameVariant == 8) { Variant8(); }
                    else if (GameVariant == 9) { Variant9(); }
                    else if (GameVariant == 10) { IGuessTheNumber(); } // change to zusatzaufgabe 1
                    else if (GameVariant == 11) { NewNumbers(); }
                }
                else if (Input.ToLower() == "")       { continue; }
                else if (Input.ToLower() == "clrs")   { for (int x = 0; x < 150; x++) { Console.WriteLine("\n"); } }
                else if (Input.ToLower() == "source") { Console.WriteLine("https://github.com/TheGreatMisconception/CodeKnacker/tree/Finished"); }
                else                                  { Console.WriteLine($"Error: Command \"{Input}\" not found"); }
            }
        }
    }
}
