using System;


namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            //Users Name
            GreetUser();

            while (true)
            {


                //int correctNumber = 7;

                //Create random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    // Make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error msg
                        PrintColorMsg(ConsoleColor.Red, "Please use an actual number.");

                        // Keep going
                        continue;
                    }

                    // put in guess 
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMsg(ConsoleColor.Red, "Wrong.Please guess again.");
                    }
                }

                //Success
                PrintColorMsg(ConsoleColor.Yellow, "You are Correct.");


                //Ask to play again
                Console.WriteLine("play again? [Y or N]");
                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer  == "Y")
                {
                    continue;
                } 
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }


        }


        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Karen Wellfare";

            //Change text Color
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        //Get user name and greet
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print Color message
        static void PrintColorMsg(ConsoleColor color, string message) {


            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
