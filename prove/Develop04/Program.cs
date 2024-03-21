using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            int choice = DisplayMenu();

            if (choice == 1)  //Breathing
            {
                Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                breathing.BreathingExercise();
            }
            else if (choice == 2)  //Reflection
            {
                Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."], ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"]);

                reflection.ReflectionExercise();
            }
            else if (choice == 3)  //Listing
            {
                Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"]);

                listing.ListingExercise();
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