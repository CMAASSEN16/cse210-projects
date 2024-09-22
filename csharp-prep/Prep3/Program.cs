using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Console.WriteLine("Welcome to the magic number!");

            Random randomGenerator = new Random();
            int magic_num = randomGenerator.Next(1, 101);

            int user_guess = -1;
            
            int guess_count = 0;

            while (user_guess != magic_num)
            {
                Console.WriteLine("What is your guess?");
                user_guess = int.Parse(Console.ReadLine());

                guess_count++;

                if (magic_num > user_guess)
                {
                    Console.WriteLine("Higher");
                }

                else if (magic_num < user_guess)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine( $"You guessed the magic number {magic_num}, it took {guess_count} tries");
                }
            }
       
        Console.WriteLine("Would you like to play again? Y or N");
        response = Console.ReadLine().ToUpper();
        } while (response != "N");
        
        Console.WriteLine("Thank you for playing!");
    }
}