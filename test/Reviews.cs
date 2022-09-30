using System;

public class reviews
{
    public string Reviewer { get; }
    public string game { get; }
    public string review { get; }
    public int timePlayed { get; }
    public double score { get; }
    public reviews(string reviewer, string game, string review, int timePlayed, double score)
    {
        this.Reviewer = reviewer;
        this.game = game;
        this.review = review;
        this.timePlayed = timePlayed;
        this.score = score;

    }
    public override string ToString() => $"\r\nReviewed by {Reviewer}:\r\n {game}\r\n {review}\r\n Time Played:{timePlayed}\r\n Final Score:{score}\r\n";
}

