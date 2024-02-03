using System;
using System.IO.Enumeration;

class Program
{

    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool running = true;
        while (running)
        {
            // System.Console.Clear();
            int choice = ShowMenu();

            if (choice == 1) 
            {
                journal.AddEntry();
            }
            else if (choice == 2) 
            {
                journal.DisplayEntries();
            }
            else if (choice == 3) 
            {
                var lines = journal.Export();
                SaveJournal(lines);
            }
            else if (choice == 4) 
            {
                var lines = LoadJournal();
                journal = new Journal(lines);
            }
            else if (choice == 5) 
            {
                    running = false;
            }
            else 
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine();
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
        Console.WriteLine();

        Console.Write("What would you like to do?");
        var choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static void SaveJournal(string[] lines)
    {
        Console.Write("Enter a filename to save the journal to: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
    static string[] LoadJournal() 
    {
        Console.Write("Enter filename to load a journal from: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }


}