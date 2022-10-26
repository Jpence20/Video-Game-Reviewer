using System;

namespace Video_Game_Reviewer
{
    public class SeeAllReviews
    {
        public static void SeeAllReviewsGames()
        {
            var result = ReviewRepo.IGNReviews().Union(ReviewRepo.EasyAllies()).Union(ReviewRepo.GameSpot()).Union(ReviewRepo.AngryJoe())
                .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }

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
            var result = ReviewRepo.EasyAllies()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }

        public static void SeeAllGameSpotReviews()
        {
            var result = ReviewRepo.GameSpot()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }


        public static void SeeAllAngryJoeReviews()
        {
            var result = ReviewRepo.AngryJoe()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }

        public static void ScoreSearching()
        {
            var result = SearchByScoreRepos.ScoreSearch10()
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (Reviews review in result.Values)
            {
                Console.WriteLine(review);
            }
        }
        public static void MyReviews()
        {
            var result = ReviewRepo.Wreview
               .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (WrittenReviews writtenReviews in result.Values)
            {
                Console.WriteLine(writtenReviews);
            }
        }

    }
}