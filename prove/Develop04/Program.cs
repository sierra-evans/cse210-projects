using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();

        bool running = true;
        while (running)
        {
            int choice = DisplayMenu();

            if (choice == 1)  //Breathing
            {
                
            }
            else if (choice == 2)  //Reflection
            {
                
            }
            else if (choice == 3)  //Listing
            {
                
            }
            else if (choice == 4)  //Quit
            {
                running = false;
            }
            else 
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static int DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine();
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();

        Console.Write("What would you like to do?");
        var choice = int.Parse(Console.ReadLine());
        return choice;
    }
}