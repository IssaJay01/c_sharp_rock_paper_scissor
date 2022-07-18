using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_rock_paper_scissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpuInput;
            int userScore = 0, cpuScore = 0;

            Console.WriteLine("Welcome to Rock, Paper, Scissors! You will be facing a CPU. First to 3 wins!");
            Console.Write("What's your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine("Ok {0}, enter your input after the prompt \"Rock, Paper, Scissors, SHOOT!\" Ready?", userName);

            while (userScore < 3 && cpuScore < 3)
            {
                Random rnd = new Random();
                int randomInt = rnd.Next(1, 4); //return random int 1,2, or 3

                Console.Write("\nRock, Paper, Scissors, SHOOT! ");
                string userInput = Console.ReadLine().ToLower();

                //CPU chooses "1"
                if (randomInt == 1)
                {
                    cpuInput = "rock";
                    Console.WriteLine("The CPU chose Rock!");
                    if (userInput == "rock")
                    {
                        Console.WriteLine("You also chose rock! DRAW.");
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else if (userInput == "paper")
                    {
                        Console.WriteLine("You chose paper! You win this round!");
                        userScore++;
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else if (userInput == "scissors")
                    {
                        Console.WriteLine("You chose scissors... CPU wins this round.");
                        cpuScore++;
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else 
                    {
                        Console.Write("I'm sorry I don't recognize that input... did you make a typo?");
                        Console.WriteLine("\nIn any case just try again.");
                    }
                }

                //CPU chooses "2"
                else if (randomInt == 2)
                {
                    cpuInput = "paper";
                    Console.WriteLine("The CPU chose Paper!");
                    if (userInput == "rock")
                    {
                        Console.WriteLine("You chose rock... CPU wins this round.");
                        cpuScore++;
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else if (userInput == "paper")
                    {
                        Console.WriteLine("You also chose paper! DRAW");
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else if (userInput == "scissors")
                    {
                        Console.WriteLine("You chose scissors! You win this round!");
                        userScore++;
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else
                    {
                        Console.Write("I'm sorry I don't recognize that input... did you make a typo?");
                        Console.WriteLine("\nIn any case just try again.");
                    }
                }

                //CPU chooses "3"
                else if (randomInt == 3)
                {
                    cpuInput = "scissors";
                    Console.WriteLine("The CPU chose Scissors!");
                    if (userInput == "rock")
                    {
                        Console.WriteLine("You chose rock! You win this round!");
                        userScore++;
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else if (userInput == "paper")
                    {
                        Console.WriteLine("You chose paper... CPU wins this round.");
                        cpuScore++;
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else if (userInput == "scissors")
                    {
                        Console.WriteLine("You also chose scissors! DRAW.");
                        Console.WriteLine("The score is now {0}:{1} - CPU:{2}", userName, userScore, cpuScore);
                    }
                    else
                    {
                        Console.Write("I'm sorry I don't recognize that input... did you make a typo?");
                        Console.WriteLine("\nIn any case just try again.");
                    }
                }
            }

            Console.WriteLine("\n\nFinal score! {0}:{1} and CPU:{2}", userName, userScore, cpuScore);
            if (userScore == 3)
                Console.WriteLine("CONGRATS {0}! YOU WON!", userName);
            else
                Console.WriteLine("CPU wins. You'll get 'em next time tiger.");
            Console.ReadLine();
        }
    }
}
