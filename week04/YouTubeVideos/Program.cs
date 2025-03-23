using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("YouTubeVideos Project.");

        Video video1 = new Video("Python Tutorial for Beginners", "John Doe", 180);
        Video video2 = new Video("Advanced Python Programming", "Jim Parson", 453);
        Video video3 = new Video("Understanding Data Structures", "Jerry Carlson", 298);
        
        // Add comments to each video
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        
        video2.AddComment(new Comment("Eve", "This was tough to understand."));
        video2.AddComment(new Comment("Mallory", "Can you explain more about recursion?"));
        video2.AddComment(new Comment("Trent", "I love advanced topics like these."));
        
        video3.AddComment(new Comment("Dave", "Data structures are essential!"));
        video3.AddComment(new Comment("Oscar", "This really helped me improve my coding skills."));
        video3.AddComment(new Comment("Peggy", "The examples were great, thanks!"));
        

        var videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayVideo();
        }


    }
}