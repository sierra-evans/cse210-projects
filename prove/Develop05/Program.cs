using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        var goals = new List<Goal> {};

        int totalPoints = 0;

        bool running = true;
        while (running)
        {
            Console.Clear();
            int choice = DisplayMenu();

            if (choice == 1)  // Create new goal
            {
                bool runningGoal = true;
                while (runningGoal)
                {
                    int selection = GoalMenu();

                    if (selection == 1) //Simple goal
                    {
                        Simple simple = new Simple();
                        goals.Add(simple);
                        runningGoal = false;
                    }

                    else if (selection == 2) //Eternal goal
                    {
                        Eternal eternal = new Eternal();
                        goals.Add(eternal);
                        runningGoal = false;
                    }
                    
                    else if (selection == 3) //Checklist goal
                    {
                        Checklist checklist = new Checklist();
                        goals.Add(checklist);
                        runningGoal = false;
                    }

                    else 
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                    }
                }
            }

            else if (choice == 2)  //List goals
            {
                int counter = 1;
                Console.WriteLine($"Total Points: {totalPoints}");
                Console.WriteLine();
                foreach (var goal in goals)
                {
                    Console.Write($"{counter}. ");  
                    goal.Display();
                    Console.WriteLine();
                    counter += 1;
                }
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadKey();
            }

            else if (choice == 3)  //Save goals
            {
                Console.WriteLine("Enter the name of the file to save the goals to:");
                string filename = Console.ReadLine();
    
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(totalPoints);
                    foreach (var goal in goals)
                    {
                        outputFile.WriteLine(goal.Export());
                    }
                }
                Console.WriteLine("Goals saved to the file.");
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadKey();
                // foreach (var goal in goals)
                // {
                //    using (StreamWriter outputFile = new StreamWriter(filename))
                //     {
                //         outputFile.Write(goal.Export());
                //     } 
                // }

                
            }

            else if (choice == 4)  //Load goals
            {
                Console.WriteLine("Enter the name of the file to load the goals from:");
                string filename = Console.ReadLine();

                string [] lines = ReadFile(filename);
                // int totalPoints = int.Parse(lines[0]);
                lines = lines.Skip(1).ToArray();
                

                // string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");

                    string identifier = parts[0];
                    string values = parts[1];

                    if (identifier == "S")
                    {
                        Simple simple = new Simple(values);
                        goals.Add(simple);
                    }

                    else if (identifier == "E")
                    {
                        Eternal eternal = new Eternal(values);
                        goals.Add(eternal);
                    }

                    else
                    {
                        Checklist checklist = new Checklist(values);
                        goals.Add(checklist);
                    }
                }

                Console.WriteLine("Goals successfully loaded from file.");
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadKey();
                
            }

            else if (choice == 5)  //Record event
            {
                Console.WriteLine("Enter the goal number you completed:");
                int goalNumber = int.Parse(Console.ReadLine());
                if (goalNumber >= 1 && goalNumber <= goals.Count)
                {
                    Goal goal = goals[goalNumber - 1];
                    totalPoints = goal.RecordEvent(totalPoints);
                }
                else
                {
                    Console.WriteLine("Invalid goal number.");
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadKey();
            }

            else if (choice == 6)  //Quit
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
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine();
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
        Console.WriteLine();

        Console.Write("What would you like to do?");
        var choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static int GoalMenu()
    {
        Console.WriteLine("The types of goal are:");
        Console.WriteLine();
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("1. Checklist goal");
        Console.WriteLine();
        Console.WriteLine("Which type of goal would you like to create?");

        var selection = int.Parse(Console.ReadLine());
        return selection;
    }

    public static string[] ReadFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        return lines;
    }

    public static void WriteFile(string filename, string content)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.Write(content);
        }
    }

    public static void WriteGoal(string fileName, Goal goal)
    {
        WriteFile(fileName, goal.Export());
    }
    
}



// TEST CODE

// using System;
// using System.Collections.Generic;
// using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {
//         var goals = new List<Goal>();

//         int totalPoints = 0;

//         bool running = true;
//         while (running)
//         {
//             Console.Clear();
//             int choice = DisplayMenu();

//             if (choice == 1)  // Create new goal
//             {
//                 bool runningGoal = true;
//                 while (runningGoal)
//                 {
//                     int selection = GoalMenu();

//                     if (selection == 1) //Simple goal
//                     {
//                         Simple simple = new Simple();
//                         goals.Add(simple);
//                         runningGoal = false;
//                     }

//                     else if (selection == 2) //Eternal goal
//                     {
//                         Eternal eternal = new Eternal();
//                         goals.Add(eternal);
//                         runningGoal = false;
//                     }

//                     else if (selection == 3) //Checklist goal
//                     {
//                         Checklist checklist = new Checklist();
//                         goals.Add(checklist);
//                         runningGoal = false;
//                     }

//                     else
//                     {
//                         Console.WriteLine("Invalid option. Please try again.");
//                     }
//                 }
//             }

//             else if (choice == 2)  //List goals
//             {
//                 int counter = 1;
//                 Console.WriteLine($"Total Points: {totalPoints}");
//                 Console.WriteLine();
//                 foreach (var goal in goals)
//                 {
//                     Console.Write($"{counter}. ");
//                     goal.Display();
//                     counter += 1;
//                 }
//             }

//             else if (choice == 3)  //Save goals
//             {
//                 Console.WriteLine("Enter the name of the file to save the goals to:");
//                 string filename = Console.ReadLine();

//                 using (StreamWriter outputFile = new StreamWriter(filename))
//                 {
//                     outputFile.WriteLine(totalPoints);
//                     foreach (var goal in goals)
//                     {
//                         outputFile.WriteLine(goal.Export());
//                     }
//                 }
//             }

//             else if (choice == 4)  //Load goals
//             {
//                 Console.WriteLine("Enter the name of the file to load the goals from:");
//                 string filename = Console.ReadLine();

//                 string[] lines = ReadFile(filename);

//                 totalPoints = int.Parse(lines[0]);

//                 for (int i = 1; i < lines.Length; i++)
//                 {
//                     string[] parts = lines[i].Split(':');

//                     string identifier = parts[0];
//                     string values = parts[1];

//                     if (identifier == "S")
//                     {
//                         Simple simple = new Simple(values);
//                         goals.Add(simple);
//                     }

//                     else if (identifier == "E")
//                     {
//                         Eternal eternal = new Eternal(values);
//                         goals.Add(eternal);
//                     }

//                     else if (identifier == "C")
//                     {
//                         Checklist checklist = new Checklist(values);
//                         goals.Add(checklist);
//                     }
//                 }
//             }

//             else if (choice == 5)  //Record event
//             {
//                 Console.WriteLine("Enter the goal number you completed:");
//                 int goalNumber = int.Parse(Console.ReadLine());
//                 if (goalNumber >= 1 && goalNumber <= goals.Count)
//                 {
//                     Goal goal = goals[goalNumber - 1];
//                     goal.RecordEvent();
//                     totalPoints += goal.GetPoints();
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid goal number.");
//                 }
//             }

//             else if (choice == 6)  //Quit
//             {
//                 running = false;
//             }

//             else
//             {
//                 Console.WriteLine("Invalid option. Please try again.");
//             }
//         }
//     }

//     static int DisplayMenu()
//     {
//         Console.WriteLine("Welcome to the Eternal Quest Program!");
//         Console.WriteLine("Please select one of the following choices:");
//         Console.WriteLine();
//         Console.WriteLine("1. Create new goal");
//         Console.WriteLine("2. List goals");
//         Console.WriteLine("3. Save goals");
//         Console.WriteLine("4. Load goals");
//         Console.WriteLine("5. Record event");
//         Console.WriteLine("6. Quit");
//         Console.WriteLine();

//         Console.Write("What would you like to do?");
//         var choice = int.Parse(Console.ReadLine());
//         return choice;
//     }

//     static int GoalMenu()
//     {
//         Console.WriteLine("The types of goal are:");
//         Console.WriteLine();
//         Console.WriteLine("1. Simple goal");
//         Console.WriteLine("2. Eternal goal");
//         Console.WriteLine("3. Checklist goal");
//         Console.WriteLine();
//         Console.WriteLine("Which type of goal would you like to create?");

//         var selection = int.Parse(Console.ReadLine());
//         return selection;
//     }

//     public static string[] ReadFile(string filename)
//     {
//         string[] lines = File.ReadAllLines(filename);
//         return lines;
//     }

//     public static void WriteFile(string filename, string content)
//     {
//         using (StreamWriter outputFile = new StreamWriter(filename))
//         {
//             outputFile.Write(content);
//         }
//     }

//     public static void WriteGoal(string fileName, Goal goal)
//     {
//         WriteFile(fileName, goal.Export());
//     }
// }
