using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Choosing a Mechanical Keyboard", "Tech Desk", 420);
        video1.AddComment(new Comment("Ana", "The sound comparison was helpful."));
        video1.AddComment(new Comment("Bruno", "I use this keyboard for programming."));
        video1.AddComment(new Comment("Carla", "Thanks for explaining the switches."));

        Video video2 = new Video("A Simple Notebook Setup", "Study Corner", 300);
        video2.AddComment(new Comment("Daniel", "I will try this layout for class."));
        video2.AddComment(new Comment("Elisa", "The notebook looks easy to carry."));
        video2.AddComment(new Comment("Felipe", "The weekly planning example helped."));

        Video video3 = new Video("Testing a Wireless Mouse", "Everyday Reviews", 240);
        video3.AddComment(new Comment("Gabriela", "The battery information was useful."));
        video3.AddComment(new Comment("Hugo", "This mouse fits my desk setup."));
        video3.AddComment(new Comment("Isabela", "Great demonstration of the buttons."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        Console.WriteLine("YOUTUBE VIDEOS");
        Console.WriteLine();

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
