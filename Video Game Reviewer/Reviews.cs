public class reviews
{
    public string reviewer { get; set; }
    public string game { get; set; }
    public string review { get; set; }
    public int timePlayed { get; set; }
    public double score { get; set; }
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
    public string reviewer { get; set; }
    public string game { get; set; }
    public string review { get; set; }
    public int timePlayed { get; set; }
    public double score { get; set; }
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
