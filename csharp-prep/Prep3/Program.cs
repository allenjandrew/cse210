using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess;

        do
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

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
                Console.WriteLine("You got it!");
            }    
        } while (guess != magic);
            
            

    }
}