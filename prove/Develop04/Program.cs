using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your new mindfulness coach/program/whatever this is!!!");
        Console.WriteLine("What activity would you like to do today?")
        Console.WriteLine("1. - Breathing Activity\n2. Reflecting Activity\n3. Listing Activity")
        int activityType = int.Parse(Console.ReadLine());

        Activity funTimesWithTyler;
        switch (activityType)
        {
            case 1
            {
                funTimesWithTyler = new BreathingActivity();
            }
            case 2
            {
                funTimesWithTyler = new ReflectingActivity();
            }
            case 3
            {
                funTimesWithTyler = new ListingActivity();
            }
        }
        
        funTimesWithTyler.StartActivity();
    }
}