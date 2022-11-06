using System;
namespace Video_Game_Reviewer
{


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
		

        public override string ToString() => $"\r\nPosition{position++}|Reviewed by: {Reviewer}|Game: {Game}| Review: {Review}|Reviewed on:{system}| Review Score:{Score}| Date Started:{DateStarted}| TimePlayed:{TimePlayed} ";
    }
}