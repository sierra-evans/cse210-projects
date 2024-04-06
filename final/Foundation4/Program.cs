using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("01 Nov 2022", 10, "Running", 5.0);
        activities.Add(running);

        Cycling cycling = new Cycling("02 Nov 2022", 20, "Cycling", 15.0);
        activities.Add(cycling);


        Swimming swimming = new Swimming("03 Nov 2022", 8, "Swimming", 20.0);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            string summary = activity.GetSummary(activity);
            Console.WriteLine(summary);
            Console.WriteLine();
        }

    }
}