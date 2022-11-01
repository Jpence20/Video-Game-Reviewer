﻿namespace Video_Game_Reviewer
{
    public class WriteReview
    {

        public static WrittenReviews SaveReview()
        {


            string reviewer = MakeReview.GetReviewer();
            string game = MakeReview.GetGame();
            string review = MakeReview.GetReview();
            string system = MakeReview.GetReviewSystem();
            double score = MakeReview.GetScore();
            string dateWritten = MakeReview.GetDate();

            WrittenReviews newReview = new($"{reviewer}", $"{game}", $"{review}", $"{system}", score, $"{dateWritten}");



            ReviewRepo.Wreview.Add(game, newReview);

            return newReview;

        }
    }
}