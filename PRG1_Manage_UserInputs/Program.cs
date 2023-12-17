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
            while (true)
            {
                Console.Write("Feed me with a number, please: ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double correct))
                {
                    Console.WriteLine($"Thanks. The number is {correct}");
                    Console.Write("Feed me again? [yes/no] ");
                    string? goAgain = Console.ReadLine()?.Trim().ToLower();
                    if (goAgain == "no")
                    {
                        Console.WriteLine("Ok. But remember me when you come across a number, yes? Bye!");
                        break;
                    }
                    else if (goAgain == "yes")
                    {
                        Console.WriteLine("Yes, yes... numbers is da best!");
                    }
                    else
                    {
                        Console.WriteLine("That was not a no, so I'll assume you want to continue.");
                    }
                }
                else
                {
                    Console.WriteLine("Nope. That's not a correct number. Try Again!");
                }
            }
        }
    }
}

