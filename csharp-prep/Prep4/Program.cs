using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //Lists
        List<int> myInts = new List<int>();
        var moreInt = new List<int>();

        moreInt.Add(34);
        moreInt.Add(10);

        foreach (var n in moreInt) {
            System.Console.WriteLine($"n = {n}");
        }

        //Assignment
        var numbers = new List<int>();
        int userNumber = -1;
        int total = 0;

        while (userNumber != 0)
        {
            System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            System.Console.WriteLine("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
            numbers.Add(userNumber);
            }
        }

        foreach (int n in numbers)
        {
            total += n;
        }

        System.Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}