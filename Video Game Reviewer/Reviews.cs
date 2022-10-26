namespace Video_Game_Reviewer
{
    public class Reviews
    {
        public string Reviewer { get; set; }
        public string Game { get; set; }
        public string Review { get; set; }
        public int TimePlayed { get; set; }
        public double Score { get; set; }
        public Reviews(string reviewer, string game, string review, int timePlayed, double score)
        {
            this.Reviewer = reviewer;
            this.Game = game;
            this.Review = review;
            this.TimePlayed = timePlayed;
            this.Score = score;

        }
        public override string ToString() => $"\r\nReviewed by {Reviewer}:\r\n {Game}\r\n {Review}\r\n Time Played:{TimePlayed}\r\n Final Score:{Score}\r\n";
    }


    public class WrittenReviews
    {
        public string Reviewer { get; set; }
        public string Game { get; set; }
        public string Review { get; set; }
        public int TimePlayed { get; set; }
        public double Score { get; set; }
        public WrittenReviews(string reviewer, string game, string review, int timePlayed, double score)
        {
            this.Reviewer = reviewer;
            this.Game = game;
            this.Review = review;
            this.TimePlayed = timePlayed;
            this.Score = score;

        }
        public override string ToString() => $"\r\nReviewed by {Reviewer}:\r\n {Game}\r\n {Review}\r\n Time Played:{TimePlayed}\r\n Final Score:{Score}\r\n";
    }
}