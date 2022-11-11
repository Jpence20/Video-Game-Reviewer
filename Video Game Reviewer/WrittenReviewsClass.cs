namespace Video_Game_Reviewer
{
    //Class for the different elements of Written Review entries
    public class WrittenReviews : Reviews
    {
        public string DateWritten { get; set; }

        public WrittenReviews(string reviewer, string game, string review, string system, double score, string dateWritten) : base(reviewer, game, review, system, score)
        {
            this.DateWritten = dateWritten;

        }
        //Put the written reviews into a format for when they are views
        public override string ToString() => $"\r\nReviewed by {Reviewer}:\r\nGame: {Game}\r\nReview: {Review}\r\nReviewed on:{System}\r\nReview Score:{Score}\r\n Date:{DateWritten}";
    }
}