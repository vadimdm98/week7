using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - камень
            //2 - ножницы
            //3 - бумага
            //камень бьет ножницы, ножницы режут бумагу, бумага оборачивает камень
            //игра должна продолжаться до того момента, пока один из игроков не наберет 3 очка

            int userScore = 0;
            int cpuScore = 0;

            Console.WriteLine("Rock - Paper - Scissors Game");
            Console.WriteLine("plays up to three points");
            Console.WriteLine("Variant choice:");

            while (userScore < 3 && cpuScore < 3)
            {
                Console.WriteLine();
                Console.WriteLine("Rock - Paper - Scissors");
                string userChoice = Console.ReadLine().ToLower();

                Console.WriteLine($"USER choice {userChoice}"); Random rnd = new Random();
                int random = rnd.Next(1, 4);
                string cpuChoice = "";

                switch (random)
                {
                    case 1:
                        cpuChoice = "paper";
                        break;
                    case 2:
                        cpuChoice = "rock";
                        break;
                    case 3:
                        cpuChoice = "scissors";
                        break;
                }

                Console.WriteLine($"CPU choice {cpuChoice}");

                if ((cpuChoice == "paper" && userChoice == "rock") || (cpuChoice == "scissors" && userChoice == "paper") || (cpuChoice == "rock" && userChoice == "scissors"))
                {
                    cpuScore++;
                    Console.WriteLine("USER lose. CPU wins!");
                }
                else if ((userChoice == "rock" && cpuChoice == "scissors") || (userChoice == "paper" && cpuChoice == "rock") || (userChoice == "scissors" && cpuChoice == "paper"))
                {
                    userScore++;
                    Console.WriteLine("USER win! CPU lose.");
                }
                else if (userChoice == cpuChoice)
                {
                    Console.WriteLine("This game was a draw.");
                }
                else
                {
                    cpuScore++;
                    Console.WriteLine("Invalid input from user, CPU wins.");
                }

                Console.WriteLine($"USER score: {userScore} - CPU score: {cpuScore}");

            }

            if (userScore == 3)
            {
                userScore++;
                Console.WriteLine("User Wins");

            }
            else
            {
                cpuScore++;
                Console.WriteLine("Cpu Wins");

            }

            Console.WriteLine("Have a nice day!");
        }
    }
}
