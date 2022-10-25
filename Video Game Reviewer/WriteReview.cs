public class WriteReview
{

    public static WrittenReviews saveReview()
    {


        string reviewer = makeReview.getReviewer();
        string game = makeReview.getGame();
        string review = makeReview.getReview();
        int timePlayed = makeReview.getTimePlayed();
        double score = makeReview.getScore();

        WrittenReviews newReview = new WrittenReviews($"{reviewer}", $"{game}", $"{review}", timePlayed, score);



        ReviewRepo.Wreview.Add(game, newReview);

        return newReview;

    }
}