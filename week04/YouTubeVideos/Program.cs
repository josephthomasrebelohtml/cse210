using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments1 = new List<Comment>();
        Comment video1Comment1 = new Comment("Lunatik34", "If anyone cares, I counted how many times she said like throughout this video, and the final tally was, like, 41. ");
        Comment video1Comment2 = new Comment("JoanneDoe88", "I've studied this recipe more than i study for my finals");
        Comment video1Comment3 = new Comment("tiger1037-s7w", "Ok, but why is her voice so soothing like I can fall asleep right now");
        comments1.Add(video1Comment1);
        comments1.Add(video1Comment2);
        comments1.Add(video1Comment3);
        Video video1 = new Video("Best Homemade Pizza You Will Ever Eat", "Scrumptious", 9.38, comments1);
        videos.Add(video1);

        List<Comment> comments2 = new List<Comment>();
        Comment video2Comment1 = new Comment("akosgeologyman93", "Going for a walk before bed while the sun is setting really changed my life.");
        Comment video2Comment2 = new Comment("peace-lover-w4t", "Every time i feel like not progressing, noel always shows up with another video that keeps me on track, ur goated ");
        Comment video2Comment3 = new Comment("Light-Editor-YT", "Nice video bro ");
        comments2.Add(video2Comment1);
        comments2.Add(video2Comment2);
        comments2.Add(video2Comment3);
        Video video2 = new Video("5 Habits That Make You Unsuccessful", "Noel Jackson", 16.20, comments2);
        videos.Add(video2);

        List<Comment> comments3 = new List<Comment>();
        Comment video3Comment1 = new Comment("TheCocoManager", "That San Andreas mod has roads more reflective than glass");
        Comment video3Comment2 = new Comment("BipityBopity2001", "No need to scroll. Everyone is talking about water.");
        Comment video3Comment3 = new Comment("Blackie029", "Water bucket + road = 4K graphics :)");
        Comment video3Comment4 = new Comment("DoggyBoom420", "This kinda seemed like it was by a guy who just recently discovered mods.");
        comments3.Add(video3Comment1);
        comments3.Add(video3Comment2);
        comments3.Add(video3Comment3);
        comments3.Add(video3Comment4);

        Video video3 = new Video("10 GRAPHICS MODS That Drastically Improve Games", "GameRanked", 9.21, comments3);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }

        
    }
}