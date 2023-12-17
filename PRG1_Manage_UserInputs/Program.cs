using System;

namespace PRG1_Manage_UserInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            TestANumber();
        }
        static void TestANumber()
        {
            Console.WriteLine("Hello World!");
            string? input;
            bool run = true;
            while (run)
            {
                Console.Write("Feed me with a number, please: ");
                input = Console.ReadLine();
                if (!double.TryParse(input, out double correct) || String.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"Nope. Not a correct number. Try Again! ");
                }
                else
                {
                    Console.WriteLine($"Thanks. The number is {correct}");
                    Console.Write("Feed me again? [y/n]");
                    string? goAgain = Console.ReadLine();
                    if (goAgain == "n" || goAgain == "N")
                    {
                        Console.WriteLine("Ok. But remember me when you come across a number, yes? Bye!");
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("Yes, eyes... numbers is da best!");
                    }
                }
            }
        }
    }
}