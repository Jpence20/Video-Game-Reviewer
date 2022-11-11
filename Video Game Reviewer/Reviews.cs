namespace Video_Game_Reviewer
{
    //Class for the different elements of The reviews in the dictionaries
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
        //puts the reviews into a certain format when search for.
        public override string ToString() => $"\r\nReviewed by {Reviewer}\r\nGame: {Game}\r\nReview TagLine: {Review}\r\nReviewed on: {System}\r\nReview Score out of 10: {Score}\r\n";
    }


   
}