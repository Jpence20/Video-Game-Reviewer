using System;

namespace Video_Game_Reviewer
{
    public class SeeAllReviews
    {
        //These methods take all the reviews in a dictionary and allows them all to be seen when the option see all reviews is selected
       
        /*public static void SeeAllReviewsGames()
        {
            var result = ReviewRepo.IGNReviews().Union(EasyAlliesReviewsRepo.EasyAllies()).Union(GameSpotReviewRepo.GameSpot()).Union(AngryJoeReviewRepo.AngryJoe())
                .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }*/

        public static void SeeAllIgnReviews()
        {
            var result = ReviewRepo.IGNReviews()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }


        public static void SeeAllEasyAlliesReviews()
        {
            var result = EasyAlliesReviewsRepo.EasyAllies()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }

        public static void SeeAllGameSpotReviews()
        {
            var result = GameSpotReviewRepo.GameSpot()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }


        public static void SeeAllAngryJoeReviews()
        {
            var result = AngryJoeReviewRepo.AngryJoe()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }

       
        public static void MyReviews()
        {
            var result = MyReviewsRepo.Wreview
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (WrittenReviews writtenReviews in result.Values)
            {
                Console.WriteLine(writtenReviews);
            }
        }
        public static void MyGamesListOrder()
        {
            var result = MyGamesList.GamesList
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (GamesToPlay games in result.Values)
            {
                Console.WriteLine(games);
            }
        }

    }
}