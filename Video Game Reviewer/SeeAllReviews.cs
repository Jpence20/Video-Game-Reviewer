using System;

public class SeeAllReviews
{
    public static void seeAllReviews()
    {
        var result = ReviewRepo.IGNReviews().Union(ReviewRepo.EasyAllies()).Union(ReviewRepo.GameSpot()).Union(ReviewRepo.AngryJoe())
            .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }

    public static void seeReviews1()
    {
        var result = ReviewRepo.IGNReviews()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }


    public static void seeReviews2()
    {
        var result = ReviewRepo.EasyAllies()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }

    public static void seeReviews3()
    {
        var result = ReviewRepo.GameSpot()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }


    public static void seeReviews4()
    {
        var result = ReviewRepo.AngryJoe()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }

    public static void scoreSearching()
    {
        var result = SearchByScoreRepos.ScoreSearch10()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }
    public static void myReviews()
    {
        var result = ReviewRepo.Wreview
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (WrittenReviews writtenReviews in result.Values)
        {
            Console.WriteLine(writtenReviews);
        }
    }

}
