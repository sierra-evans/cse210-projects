using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        var video1 = new Video("How To Sew A Purse", "Sally", 40);
        var video2 = new Video("Why You Need To Eat Breakfast", "Meredith", 70);
        var video3 = new Video("How To Make Each Day Worth It", "Finley", 120);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        int counter = 1;
        foreach (var video in videos)
        {
            Console.WriteLine($"Video {counter}");
            Console.WriteLine("-------------------------------------------");
            int numberOfComments = video.NumberOfComments();
            video.DisplayVideo(numberOfComments);
            Console.WriteLine();
            counter += 1;
        }
    }
}