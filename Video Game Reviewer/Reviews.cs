using System;

public class reviews
{
    public string reviewer { get; }
    public string game { get; }
    public string review { get; }
    public int timePlayed { get; }
    public double score { get; }
    public reviews(string reviewer, string game, string review, int timePlayed, double score)
    {
        this.reviewer = reviewer;
        this.game = game;
        this.review = review;
        this.timePlayed = timePlayed;
        this.score = score;

    }
    public override string ToString() => $"\r\nReviewed by {reviewer}:\r\n {game}\r\n {review}\r\n Time Played:{timePlayed}\r\n Final Score:{score}\r\n";
}


public class WrittenReviews
{
    public string reviewer { get;  }
    public string game { get; }
    public string review { get; }
    public int timePlayed { get; }
    public double score { get; }
    public WrittenReviews(string reviewer, string game, string review, int timePlayed, double score)
    {
        this.reviewer = reviewer;
        this.game = game;
        this.review = review;
        this.timePlayed = timePlayed;
        this.score = score;

    }
    public override string ToString() => $"\r\nReviewed by {reviewer}:\r\n {game}\r\n {review}\r\n Time Played:{timePlayed}\r\n Final Score:{score}\r\n";
}
