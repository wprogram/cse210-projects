using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create Video objects
        Video video1 = new Video("Learning C# Basics", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video! Very helpful."));
        video1.AddComment(new Comment("Bob", "Thanks for the tips!"));
        video1.AddComment(new Comment("Charlie", "Looking forward to more videos."));

        Video video2 = new Video("Advanced C# Concepts", "Jane Smith", 600);
        video2.AddComment(new Comment("Dave", "I learned a lot from this!"));
        video2.AddComment(new Comment("Eve", "Very informative!"));
        video2.AddComment(new Comment("Frank", "Can't wait to apply this knowledge."));

        Video video3 = new Video("C# Best Practices", "Mike Johnson", 450);
        video3.AddComment(new Comment("Grace", "Excellent content, as always!"));
        video3.AddComment(new Comment("Heidi", "I appreciate the detailed explanations."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
