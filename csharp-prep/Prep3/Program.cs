using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic; 
        int count = 0;
        int guess;

        do
        {
            do
            {
                magic = randomGenerator.Next(1, 101);
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());

                count ++;

                if (guess > magic)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess == magic)
                {
                    Console.WriteLine($"You got it! It took you {count} guesses.");
                }    
            } while (guess != magic);

            Console.WriteLine("Would you like to play again? (y/n) ");
        } while (Console.ReadLine() == "y");
            
    }
}