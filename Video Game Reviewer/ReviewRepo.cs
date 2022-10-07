using System;
using System.Security.Cryptography.X509Certificates;
using VideoGameReviewer;
using static System.Formats.Asn1.AsnWriter;

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
            { "god of war-a", godOfWar }
        };
        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsB()
    {
        reviews godOfWar = new reviews("Jessica Pence", "God of war", "Okay Game", 40, 8);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war-b", godOfWar }
        };
        return reviews;
    }
    public static Dictionary<string, reviews> InitializeReviewsC()
    {
        reviews godOfWar = new reviews("Brian Maggard", "God of war", "Great Game", 60, 10);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war-c", godOfWar }
        };
        
        return reviews;
    }


    

    public static Dictionary<string, WrittenReviews> Wreview()
    {
        string reviewer = makeReview.getReviewer();
        string game = makeReview.getGame();
        string review = makeReview.getReview();
        int timePlayed = makeReview.getTimePlayed();
        double score = makeReview.getScore();

        WrittenReviews newReview = new WrittenReviews($"{reviewer}", $"{game}", $"{review}", timePlayed, score);
        var reviews = new Dictionary<string, WrittenReviews>
        {
            { $"{game}", newReview }
        };
        return reviews;
    }


   





}

