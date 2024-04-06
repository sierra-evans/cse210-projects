using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("The Effects of Food on Mental Health", "Food scientist Cally R. Stein will be discussing why and how what we eat affects our mental health.", "November 20th, 2022", "6:00 pm", "Lecture", "Cally R. Stein", 300);

        Console.WriteLine("Lecture");
        Console.WriteLine();
        Console.WriteLine("Short");
        Console.WriteLine("-----------------------");
        lecture.DisplayShort();
        Console.WriteLine();
        Console.WriteLine("Standard");
        Console.WriteLine("-----------------------");
        lecture.DisplayStandard();
        Console.WriteLine();
        Console.WriteLine("Full");
        Console.WriteLine("-----------------------");
        lecture.DisplayFull();
        Console.WriteLine();
        

        Outdoor outdoor = new Outdoor("Easter Egg Hunt", "We will be conducting an Easter egg hunt after a brief lesson aout Easter, come and join the fun!", "March 20th, 2024", "1:30 pm", "Outdoor", "Partly Cloudy");

        Console.WriteLine("Outdoor");
        Console.WriteLine();
        Console.WriteLine("Short");
        Console.WriteLine("-----------------------");
        outdoor.DisplayShort();
        Console.WriteLine();
        Console.WriteLine("Standard");
        Console.WriteLine("-----------------------");
        outdoor.DisplayStandard();
        Console.WriteLine();
        Console.WriteLine("Full");
        Console.WriteLine("-----------------------");
        outdoor.DisplayFull();
        Console.WriteLine();

        Reception reception= new Reception("Clive and Jill's Reception", "Come celebrate the union of this beautiful couple!", "July 22nd, 2023", "4:00 pm", "Reception", "candjrec@gmail.com");

        Console.WriteLine("Reception");
        Console.WriteLine();
        Console.WriteLine("Short");
        Console.WriteLine("-----------------------");
        reception.DisplayShort();
        Console.WriteLine();
        Console.WriteLine("Standard");
        Console.WriteLine("-----------------------");
        reception.DisplayStandard();
        Console.WriteLine();
        Console.WriteLine("Full");
        Console.WriteLine("-----------------------");
        reception.DisplayFull();
    }

    // static void DisplayDetails(Event event)
    // {

    // }
}