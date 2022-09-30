using System;

public class ReviewRepo
{
    public static Dictionary<string, reviews> InitializeReviews()
    {
        reviews godOfWar = new reviews("Jeremy Pence", "God of war", "Great Game", 40, 10);
        reviews godOfWar1 = new reviews("John Pence", "God of war", "Hated it", 40, 3);

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

}
