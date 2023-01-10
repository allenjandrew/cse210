using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers one at a time; type 0 to finish.");
        
        int number;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int max = numbers.Max();
        int total = 0;
        List<int> noNegs = new List<int>();

        foreach (int numb in numbers)
        {
            total += numb;
            if (numb > 0)
            {
                noNegs.Add(numb);
            }
        }

        int min = noNegs.Min();
        numbers.Sort();

        int average = total / numbers.Count;
        Console.WriteLine($"Total: {total}\nAverage: {average}\nLargest number: {max}\nSmallest number: {min}\nSorted list:");
        foreach (int order in numbers)
        {
            Console.WriteLine(order);
        }

    }
}