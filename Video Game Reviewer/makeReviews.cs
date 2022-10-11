using System;

public class makeReview
{
    public static string getReviewer()
    {
        Console.WriteLine("What is your name?");

        string reviewer = Console.ReadLine() ?? string.Empty;
        return reviewer;
    }

    public static string getGame()
    {
        Console.WriteLine("What is the name of the game you want to review");
        string game = Console.ReadLine() ?? string.Empty;
        return game;
    }
    public static string getReview()
    {
        Console.WriteLine("Write out your review.");
        string review = Console.ReadLine() ?? string.Empty;
        return review;
    }
    public static int getTimePlayed()
    {
        Console.WriteLine("How many hours did you play");
        int timePlayed = int.Parse(Console.ReadLine());
        return timePlayed;
    }
    public static double getScore()
    {

        Console.WriteLine("What is your score for the game out of 10");
        double score = double.Parse(Console.ReadLine());
        return score;
    }
}
