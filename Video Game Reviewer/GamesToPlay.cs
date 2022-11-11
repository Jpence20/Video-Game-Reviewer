using System;
namespace Video_Game_Reviewer
{

    //Class for the different elements of Games List entries
    public class GamesToPlay : Reviews
	{
		public String DateStarted { get; set; }
		public int TimePlayed { get; set; }
		public int position = 1;

		public GamesToPlay(string reviewer, string game, string review, string system, double score,string DateStarted,int TimePlayed) : base(reviewer, game, review, system, score)
		{
			this.DateStarted = DateStarted;
			this.TimePlayed = TimePlayed;

		}

        //puts the entires into a certain format when looking at the list of games to play.
        public override string ToString() => $"\r\nPosition{position++}|Reviewed by: {Reviewer}|Game: {Game}| Review: {Review}|Reviewed on:{System}| Review Score:{Score}| Date Started:{DateStarted}| TimePlayed:{TimePlayed} ";
    }
}