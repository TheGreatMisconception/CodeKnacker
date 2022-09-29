using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKnacker
{
    class Program
    {
        private static bool CanConvert(string Num) {
            try
            {
                Convert.ToInt32(Num);
            }
            catch {
                Console.WriteLine("Your Input is not a valid number, try again");
                return false;            
            }
            return true;
        }
        private static int[] GetUserNumber() {
            string Number;
            string RangeMin;
            string RangeMax;
            bool CorrectInput;
            CorrectInput = false;
            Number = "lol";
            RangeMin = RangeMax = "!"; // shitty ide doesnt get variable definition within while loop
            while (CorrectInput != true) {
                Console.WriteLine("Please enter you're secret number");
                Number = Console.ReadLine();
                Console.WriteLine("Please the minimum range in which the number is present:");
                RangeMin = Console.ReadLine();
                Console.WriteLine("Please the maximum range in which the number is present:");
                RangeMax = Console.ReadLine();

                if (CanConvert(Number) && CanConvert(RangeMin) && CanConvert(RangeMax)) {
                    CorrectInput = true;
                }
            }
            return new int[] { Convert.ToInt32(Number), Convert.ToInt32(RangeMin),  Convert.ToInt32(RangeMax)};
        }

        private static void IGuessTheNumber() {
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
                Random = RND.Next(MyRange[1], MyRange[2]);
                Console.WriteLine($"Is your number smaller or greater than {Random}?");
                Console.WriteLine("l/g/=");
                while (Input != "g" || Input != "l" || Input != "=")
                {
                    Input = Console.ReadLine();
                    Input = Input.ToLower();

                    if (Input == "g")
                    {
                        MyRange[1] = Random;
                    }
                    else if (Input == "l")
                    {
                        MyRange[2] = Random;
                    }
                    else
                    {
                        Console.WriteLine("COOOOOOL\n\nPress any key to exit....");
                        Console.ReadKey();
                        Guessed = true;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            IGuessTheNumber();
        }
    }
}
