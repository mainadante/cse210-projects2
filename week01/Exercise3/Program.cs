using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

      
        // Console.Write("What is the magic number? ");
        // string answer1 = Console.ReadLine();
        // int magicNumber = int.Parse(answer1);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string answer2 = Console.ReadLine();
        int guess = int.Parse(answer2);

        while (guess != magicNumber)
        {

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }


            Console.Write("What is your guess? ");
            answer2 = Console.ReadLine();
            guess = int.Parse(answer2);
        }
        
        Console.WriteLine("You guessed it!");
        


       
        

    }
}