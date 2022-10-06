using System;
using VideoGameReviewer;

public class ReviewRepo
{
    public static Dictionary<string, reviews> InitializeReviews()
    {
        reviews godOfWar = new reviews("Jeremy Pence", "God of war", "Great Game", 40, 10);
        reviews persona5 = new reviews("Jeremy Pence", "Persona 5", "Amazing Game", 100, 10);

        var reviews = new Dictionary<string, reviews>
        {
            { "god of war", godOfWar },
            { "Persona 5", persona5 }
        };

        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsA()
    {
        reviews godOfWar = new reviews("John Pence", "God of war", "Great Game", 40, 10);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war", godOfWar }
        };
        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsB()
    {
        reviews godOfWar = new reviews("Jessica Pence", "God of war", "Okay Game", 40, 8);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war", godOfWar }
        };
        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsC()
    {
        reviews godOfWar = new reviews("Brian Maggard", "God of war", "Great Game", 60, 10);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war", godOfWar }
        };
        return reviews;
    }


  
    public static Dictionary<string, WrittenReviews> WReview()
    {
        Console.WriteLine("What is your name?");
        string reviewer = Console.ReadLine();
        Console.WriteLine("What is the name of the game you want to review");
        string game = Console.ReadLine();
        Console.WriteLine("Write out your review.");
        string review = Console.ReadLine();
        Console.WriteLine("How many hours did you play");
        int timePlayed = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your score for the game out of 10");
        double score = double.Parse(Console.ReadLine());
        

        WrittenReviews NewReview = new WrittenReviews($"{reviewer}", $"{game}", $"{review}", timePlayed, score);
        var reviews = new Dictionary<string, WrittenReviews>
        {
            { $"{game}", NewReview}
        };
        return reviews;
       
    }

    
}
