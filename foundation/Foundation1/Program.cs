using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Createing the instances of the Video Class    
        var video1 = new Video("How to build a sturdy folding chair", "Bob The Builder", 600);
        var video2 = new Video("My Time in Scotland", "The Wannabe Scott", 485);
        var video3 =  new Video("Learn To Play Trumpet in 15 Minutes", "Master Trumpit", 900);

        // Adding comments to the videos using the method AddCommment
        video1.AddComment(new Comment("Crystal", "Thank you for showing us how to do things for ourselves!"));
        video1.AddComment(new Comment("MasterChief07", "Your jointery rocks, I appreciate your skill"));
        video1.AddComment(new Comment("BillTheKid", "Awesome build, I look forward to building it once lumber rates comes down"));

        video2.AddComment(new Comment("TristanPiper", "Oh to hear the sound of the bagpipes rolling through the Scotish hills. P.S. Nice Kilt!!!"));
        video2.AddComment(new Comment("ILoveNature", "Can I just live in that castle for the rest of my life?????"));
        video2.AddComment(new Comment("BritsAreBest", "It is beautiful but nothing like the London Eye"));

        video3.AddComment(new Comment("BrassMaster", "Great job teaching the basics, hope all will continue to practice more."));
        video3.AddComment(new Comment("BullDog27", "I finally made an actual note, hopefully my mom won't get as annoyed anymore."));

        // Creating list to store videos
        var videos = new List<Video> {video1, video2, video3};

        // Displays each video in the list when iterating through videos
        foreach (var video in videos)
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~\n");
            video.DisplayVideoInfo();
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~");
        }
    }
}