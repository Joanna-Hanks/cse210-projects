using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Babylirious Strikes Back", "Shadows", 600);

        Comment c1 = new Comment("Hydrokinesis", "There he goes!");
        Comment c2 = new Comment("Icey", "He has a sword!");
        Comment c3 = new Comment("Honed", "You idiot, we all have swords!");

        Video video2 = new Video("How to close a door", "Siblings", 60);

        Comment c4 = new Comment("Hunter", "Can confirm, it does work");
        Comment c5 = new Comment("hint", "If I do the opposite, will it open the door");
        Comment c6 = new Comment("Siblings", "Opening a door is a different video");
        Comment c7 = new Comment("hint", "oh......");

        Video video3 = new Video("How to OPEN a door, as demanded", "Siblings&Company", 120);

        Comment c8 = new Comment("hint", "Crazy that it takes twice as long to open a door then to close it...");
        Comment c9 = new Comment("Kitsune", "If you open the door hard enough, it will close by itself");
        Comment c10 = new Comment("hint", "Just tried it, ended up with a concussion, but the door did close by itself");


        video1.AddComment(c1);
        video1.AddComment(c2);
        video1.AddComment(c3);
        video2.AddComment(c4);
        video2.AddComment(c5);
        video2.AddComment(c6);
        video2.AddComment(c7);
        video3.AddComment(c8);
        video3.AddComment(c9);
        video3.AddComment(c10);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.DisplayVideo();

        }
    }
}