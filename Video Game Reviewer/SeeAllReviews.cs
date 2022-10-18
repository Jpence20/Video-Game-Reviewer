using System;

public class SeeAllReviews
{
    public static void seeAllReviews()
    {
        var result = ReviewRepo.InitializeReviews().Union(ReviewRepo.InitializeReviewsA()).Union(ReviewRepo.InitializeReviewsB()).Union(ReviewRepo.InitializeReviewsC())
            .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }

    public static void seeReviews1()
    {
        var result = ReviewRepo.InitializeReviews()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }


    public static void seeReviews2()
    {
        var result = ReviewRepo.InitializeReviewsA()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }

    public static void seeReviews3()
    {
        var result = ReviewRepo.InitializeReviewsB()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }


    public static void seeReviews4()
    {
        var result = ReviewRepo.InitializeReviewsC()
           .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

        foreach (reviews review in result.Values)
        {
            Console.WriteLine(review);
        }
    }


}
