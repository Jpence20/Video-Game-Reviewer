using System;

namespace Video_Game_Reviewer
{
	public class GetGameListValues
	{
		public static GamesToPlay GetValues()
		{
            string reviewer = MakeReview.GetReviewer();
            string game = MakeReview.GetGame();
            string review = MakeReview.GetReview();
            string system = MakeReview.GetReviewSystem();
            double score = MakeReview.GetScore();
            string datestarted = MakeReview.GetStartDate();
            int TimePlayed = MakeReview.GetTimePlayed();

            GamesToPlay newListEntry = new($"{reviewer}", $"{game}", $"{review}", $"{system}", score, $"{datestarted}",TimePlayed);



            MyGamesList.GamesList.Add(game, newListEntry);
            return newListEntry;
        }
	}
}