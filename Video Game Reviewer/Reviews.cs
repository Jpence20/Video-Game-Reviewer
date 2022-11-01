namespace Video_Game_Reviewer
{
    public class Reviews
    {
        public string Reviewer { get; set; }
        public string Game { get; set; }
        public string Review { get; set; }
        public string system { get; set; }
        public double Score { get; set; }
        public Reviews(string reviewer, string game, string review, string system, double score)
        {
            this.Reviewer = reviewer;
            this.Game = game;
            this.Review = review;
            this.system = system;
            this.Score = score;

        }
        public override string ToString() => $"\r\nReviewed by {Reviewer}\r\nGame: {Game}\r\nReview: {Review}\r\nReviewed on: {system}\r\nReview Score: {Score}\r\n";
    }


    public class WrittenReviews : Reviews
    {
        public string DateWritten { get; set; }

        public WrittenReviews(string reviewer, string game, string review, string system, double score,string dateWritten) : base(reviewer, game, review, system, score)
        {
            this.DateWritten = dateWritten;

        }
        public override string ToString() => $"\r\nReviewed by {Reviewer}:\r\nGame: {Game}\r\nReview: {Review}\r\nReviewed on:{system}\r\nReview Score:{Score}\r\n Date:{DateWritten}";
    }
}