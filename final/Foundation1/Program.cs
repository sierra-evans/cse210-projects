using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        var video1 = new Video("Start", "Sally", 40);
        var video2 = new Video("Middle", "Meredith", 70);
        var video3 = new Video("Finish", "Finley", 120);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            int numberOfComments = video.NumberOfComments();
            video.DisplayVideo(numberOfComments);
        }
    }
}