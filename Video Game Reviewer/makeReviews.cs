public class makeReview
{
    public static string getReviewer()
    {
       
        Console.WriteLine("What is your name?");
        string reviewer = Console.ReadLine() ?? string.Empty;
        if (reviewer == string.Empty)
        {
            Console.WriteLine("Please enter a Name");
            getReviewer();
        }
        
        return reviewer ?? string.Empty;
    }

    public static string getGame()
    {
        Console.WriteLine("What is the name of the game you want to review");
        string game = Console.ReadLine() ?? string.Empty;
        if(game == string.Empty)
        {
            Console.WriteLine("Please enter a Game");
            getScore();
        }
        return game;
    }
    public static string getReview()
    {
        Console.WriteLine("Write out your review.");
        string review = Console.ReadLine() ?? string.Empty;
        if(review == string.Empty)
        {
            Console.WriteLine("Please enter a Review");
            getReview();

        }
        return review;
    }
    public static int getTimePlayed()
    {
        int timePlayed;
        Console.WriteLine("How many hours did you play");
        if (int.TryParse(Console.ReadLine(), out timePlayed))
        {
            return timePlayed;
        }
        else
        Console.WriteLine("Please Enter a valid Number");
        return getTimePlayed();
    }
    public static double getScore()
    {
        double score;
        Console.WriteLine("What is your score for the game out of 10");
        if (double.TryParse(Console.ReadLine(),out score))
        {
            return score;
        }
        Console.WriteLine("Please Enter a Valid Number");
        return getScore();
    }
}
