using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // while loop
        int count = 5;

        while (count < 10)
        {
            System.Console.WriteLine($"Count = {count++}");
        }

        while (count < 15)
        {
            System.Console.WriteLine($"Count = {count}");
            count++;
        }

        // do-while loop

        int anotherCount = 0;

        do 
        {
            System.Console.WriteLine($"AnotherCount = {++anotherCount}");   // ++ increments the variable by one
        } while (anotherCount < 10);

        // for loop
        for (int i = 0; i < 5; ++i) {
            System.Console.WriteLine($"i = {i}");
        }

        //Assignment
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        
        while (randomNumber != guess)
        {
        System.Console.WriteLine("Guess a random number:");
        guess = int.Parse(Console.ReadLine());

        if(guess > randomNumber) {
            System.Console.WriteLine("Too high!");
        }
        else if (guess < randomNumber) {
            System.Console.WriteLine("Too low!");
        }
        else {
            System.Console.WriteLine("Correct!");
        }
        }
    }
}