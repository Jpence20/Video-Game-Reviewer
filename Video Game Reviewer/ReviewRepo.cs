using System;

public class ReviewRepo
{
    public static Dictionary<string, reviews> InitializeReviews()
    {
        reviews godOfWar = new reviews("Jeremy Pence", "God of war", "Great Game", 40, 10);

        var reviews = new Dictionary<string, reviews>();
        reviews.Add("god of war", godOfWar);
        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsA()
    {
        reviews godOfWar = new reviews("John Pence", "God of war", "Great Game", 40, 10);
        var reviews = new Dictionary<string, reviews>();
        reviews.Add("god of war", godOfWar);
        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsB()
    {
        reviews godOfWar = new reviews("Jessica Pence", "God of war", "Okay Game", 40, 8);
        var reviews = new Dictionary<string, reviews>();
        reviews.Add("god of war", godOfWar);
        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsC()
    {
        reviews godOfWar = new reviews("Brian Maggard", "God of war", "Great Game", 60, 10);
        var reviews = new Dictionary<string, reviews>();
        reviews.Add("god of war", godOfWar);
        return reviews;
    }

}
