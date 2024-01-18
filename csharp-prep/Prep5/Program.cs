using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        //Functions
        // returnType FunctionName(ParamType paranName1, paramType paramName2)
        // {
        //     Function body
        // }

        int Add2(int number) {
            return number + 2;
        }

        int more = Add2(10);

        // void returns nothing (here we void because the function prints the statement, so no need to return a value)
        void PrintName(string name) {
            System.Console.WriteLine($"Name is {name}");
        }

        PrintName("Bob");

        // variable scope
        var y = 0;
        {
            var w =  10;
            w = y +4;
            y = w + 5;
        }
        // y = w + 4;   can't use 'w' outside of its scope
        
        //Assignment
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        // PromptUserName - Asks for and returns the user's name (as a string)
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        // DisplayResult - Accepts the user's name and the squared number and displays them.
        // Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
        void DisplayWelcome()
        {
            System.Console.WriteLine("Welcome to the program!");
        }
        string PromptUserName()
        {
            System.Console.WriteLine("Please enter your first and last name:");
            string userName = Console.ReadLine();
            return userName;
        }
        int PromptUserNumber()
        {
            System.Console.WriteLine("What is your favorite number:");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        int SquareNumber(int userNumber)
        {
            int squared = userNumber * userNumber;
            return squared;
        }
        void DisplayResult(string userName, int squared)
        {
            System.Console.WriteLine($"{userName}, your favorite number squared is: {squared}");
        }
        void main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squared = SquareNumber(userNumber);
            DisplayResult(userName, squared);
        }

        main();
    }
}