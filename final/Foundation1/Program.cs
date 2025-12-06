using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Train Your Dog", "PetCoach", 540);
        Video video2 = new Video("DIY Wooden Shelf", "5 minute crafts", 780);
        Video video3 = new Video("Top 10 Coding Tips", "DeveloperTips", 620);
        Video video4 = new Video("Exploring the Amazon Rainforest", "Outdoor Boys", 905);

        video1.AddComment(new Comment("User1", "Great tips! My dog learned fast!"));
        video1.AddComment(new Comment("User2", "Loved the energy of the trainer."));
        video1.AddComment(new Comment("User3", "Could you make a video on leash pulling?"));

        video2.AddComment(new Comment("User1", "This was easy to follow. Thanks!"));
        video2.AddComment(new Comment("User2", "My shelf turned out amazing."));
        video2.AddComment(new Comment("User3", "Very clear instructions."));

        video3.AddComment(new Comment("User1", "Tip #4 changed everything."));
        video3.AddComment(new Comment("User2", "Shared this with my students!"));
        video3.AddComment(new Comment("User3", "Super helpful and clear."));

        video4.AddComment(new Comment("User1", "The visuals were stunning."));
        video4.AddComment(new Comment("User2", "Felt like I was there!"));
        video4.AddComment(new Comment("User3", "Please show more wildlife next time."));

        List<Video> videos = new List<Video>() { video1, video2, video3, video4 };

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"  - {c.Commenter}: {c.Text}");
            }

            Console.WriteLine();
        }
    }
}
