namespace Video_Game_Reviewer
{
    public class Reviews
    {
        public string Reviewer { get; set; }
        public string Game { get; set; }
        public string Review { get; set; }
        public string System { get; set; }
        public double Score { get; set; }
        public Reviews(string reviewer, string game, string review, string system, double score)
        {
            this.Reviewer = reviewer;
            this.Game = game;
            this.Review = review;
            this.System = system;
            this.Score = score;

        }
        public override string ToString() => $"\r\nReviewed by {Reviewer}\r\nGame: {Game}\r\nReview TagLine: {Review}\r\nReviewed on: {System}\r\nReview Score: {Score}\r\n";
    }


   
}