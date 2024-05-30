using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create some videos
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 600);
        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 800);

        // Add comments to the videos
        video1.AddComment(new Comment("User1", "Great introduction!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "Good pacing and clear explanations."));

        video2.AddComment(new Comment("User4", "Loved the advanced topics!"));
        video2.AddComment(new Comment("User5", "Well structured content."));
        video2.AddComment(new Comment("User6", "A bit too fast, but informative."));

        video3.AddComment(new Comment("User7", "Excellent overview of design patterns."));
        video3.AddComment(new Comment("User8", "Very detailed and thorough."));
        video3.AddComment(new Comment("User9", "Helped me understand patterns better."));

        // Store the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the details of each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}