using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Elden Ring Lets Play", "ButterMyLoaf", 1500);
        video1.AddComment(new Comment("CoolUser67", "Love your videos bro!"));
        video1. AddComment(new Comment("Markiplier", "We should play sometime together."));
        video1. AddComment(new Comment("Smi77y", "So cool man."));

        Video video2 = new Video ("Math Basics", "Professor Higginbottom", 750);
        video2. AddComment(new Comment("Mathsux", "This helped me understand math more."));
        video2. AddComment(new Comment("Boston", "I used to think math was hard, but this simplified it for me."));
        video2. AddComment(new Comment("Proxy", "Great content."));

        Video video3 = new Video ("Strolling through Manhattan Vlog", "Dillon", 1200);
        video3. AddComment(new Comment("WanderingVagrant", "Love the videos, keep them coming."));
        video3. AddComment(new Comment("Traveling Salesman", "Maybe I'll walk through there sometime too."));
        video3. AddComment(new Comment("RandomUser69", "This is perfect for background noise while I study."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}