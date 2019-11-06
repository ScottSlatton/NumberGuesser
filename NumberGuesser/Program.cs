using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while (true)
            { 

            //Set correctNumber

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            //Set GuessNumber

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10.");

            while (guess != correctNumber)
            {
                string input = Console.ReadLine();

                //Make sure it's a number
                
                if(!int.TryParse(input, out guess))
                {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number.");
                    continue;

                }

                //Cast to int and store into guess

                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                }
            }
                PrintColorMessage(ConsoleColor.Green, "You are correct!");

                Console.WriteLine("Would you like to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                if (answer == "N")
                {
                    return;
                }
            }
        }

        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void GreetUser()
        {

            //Ask user's name and greet
            Console.WriteLine("What is your name?");

            string username = Console.ReadLine();

            Console.WriteLine($"Hello {username}, lets play a game.");
        }

        private static void GetAppInfo()
        {
            //Get and display app info
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Scott Slatton";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            Console.ResetColor();
        }
    }
}
