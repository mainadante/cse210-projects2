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

        int sum = 0;
        foreach (int n in listNumbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = 0;
        if (listNumbers.Count > 0)
        {
            average = (float)sum / listNumbers.Count;
        }
        Console.WriteLine($"The average is: {average}");

        int largest = listNumbers[0];
        foreach (int n in listNumbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositive = int.MaxValue;
        foreach (int n in listNumbers)
        {
            if (n > 0 && n < smallestPositive)
            {
                smallestPositive = n;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        listNumbers.Sort();
        Console.WriteLine("The sorted list is: ");
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