using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 42;

            Console.WriteLine($"Guess my favorite number?");

            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine($"Too Low");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine($"Too High.");
            }
            else
            {
                Console.WriteLine($"Nevermind.");
            }

            var subject = "History";

            Console.WriteLine($"What is your favorite school subject?");

            var userGuess2 = Console.ReadLine();

            switch (userGuess2)
            {
                case "English":
                    Console.WriteLine($"Really? English is so boring.");
                    break;
                case "Math":
                    Console.WriteLine($"Math was one of my best subjects!");
                    break;
                case "Science":
                    Console.WriteLine($"Surely the best would have to be computer science righ?");
                    break;
                case "Art":
                    Console.WriteLine($"Wow, I was never much of an artist myself.");
                    break;
                case "History":
                    Console.WriteLine($"Mine as well! It was my favorite because it was the easiest");
                    break;
                    default: Console.WriteLine($"Oof, that is not a subject I am too familiar with.");
                    break;


            }
            
        }
    }
}