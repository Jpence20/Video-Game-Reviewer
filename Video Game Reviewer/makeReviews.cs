namespace Video_Game_Reviewer
{
    public class MakeReview
    {
        public static string GetReviewer()
        {

            Console.WriteLine("What is your name?");
            string reviewer = Console.ReadLine() ?? string.Empty;
            if (reviewer == string.Empty)
            {
                Console.WriteLine("Please enter a Name");
                GetReviewer();
            }

            return reviewer ?? string.Empty;
        }

        public static string GetGame()
        {
            Console.WriteLine("What is the name of the game you want to review");
            string game = Console.ReadLine() ?? string.Empty;
            if (game == string.Empty)
            {
                Console.WriteLine("Please enter a Game");
                GetGame();
            }
            return game;
        }
        public static string GetReview()
        {
            Console.WriteLine("Write out your review.");
            string review = Console.ReadLine() ?? string.Empty;
            if (review == string.Empty)
            {
                Console.WriteLine("Please enter a Review");
                GetReview();

            }
            return review;
        }
        public static int GetTimePlayed()
        {
            Console.WriteLine("How many hours did you play");
            if (int.TryParse(Console.ReadLine(), out int timePlayed))
            {
                return timePlayed;
            }
            else
                Console.WriteLine("Please Enter a valid Number");
            return GetTimePlayed();
        }

        public static string GetReviewSystem()
        {
            Console.WriteLine("What System Did you Play the Game on?.");
            string system = Console.ReadLine() ?? string.Empty;
            if (system == string.Empty)
            {
                Console.WriteLine("Please enter a Review");
                GetReviewSystem();

            }
            return system;
        }


        public static double GetScore()
        {
            Console.WriteLine("What is your score for the game out of 10");
            if (double.TryParse(Console.ReadLine(), out double score))
            {
                return score;
            }
            Console.WriteLine("Please Enter a Valid Number");
            return GetScore();
        }

        public static string GetDate()
        {
            Console.WriteLine("When day do you beat this game");
            string dateWritten = Console.ReadLine() ?? string.Empty;
            if (dateWritten == string.Empty)
            {
                Console.WriteLine("Please enter a Review");
                GetReviewSystem();

            }
            return dateWritten;
        }

        public static string GetStartDate()
        {
            Console.WriteLine("What date did you start this game?");
            string dateStarted = Console.ReadLine() ?? string.Empty;
            if (dateStarted == string.Empty)
            {
                Console.WriteLine("Please enter a Review");
                GetReviewSystem();

            }
            return dateStarted;
        }

    }
}