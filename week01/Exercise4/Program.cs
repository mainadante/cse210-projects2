using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> listNumbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                listNumbers.Add(number);
            }

        }
        
        Console.WriteLine("You entered:");
        foreach (int n in listNumbers)
        {
            Console.WriteLine(n);
        }


    }
}

// See more for these in Week1!!

// Python
// print("Hello World!")

// C#
// Console.WriteLine("Hello World!");
// or Console.Write("")

// int x;
// x = 5;
// Console.WriteLine(x);

// int x = 5;
// Console.WriteLine(x);