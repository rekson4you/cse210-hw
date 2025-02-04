using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating sample videos and comments
        var video1 = new Video("Python Tutorial", "John Tunmise", 400);
        video1.AddComment(new Comment("Damilare", "Awesome tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Babatunde", "Learned a lot!"));

        var video2 = new Video("How to Cook Pasta", "Jane Greg", 700);
        video2.AddComment(new Comment("David", "Looks delicious!"));
        video2.AddComment(new Comment("Eve", "I need to try this recipe."));

        var video3 = new Video("Travel Vlog: Paris", "Timilehin Ojo", 1000);
        video3.AddComment(new Comment("Fiona", "Beautiful video!"));
        video3.AddComment(new Comment("Taiwo", "Paris is amazing."));
        video3.AddComment(new Comment("Hannah", "Can't wait to visit!"));

        // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying the information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}