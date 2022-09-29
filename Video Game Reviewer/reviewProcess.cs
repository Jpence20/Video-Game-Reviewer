using System;
using System.Xml.Schema;
using videoGameReviewer;

public class VGameReviewer
{
	string reviewer;
	string game;
	string review;
	int timePlayed;
	double score;

	public VGameReviewer(string reviewer, string game, string review, int timePlayed, double score)
	{
		this.reviewer = reviewer;
		this.game = game;
		this.review = review;
		this.timePlayed = timePlayed;
		this.score = score;
	}
	public static string getreviewer(string reviewer)
	{
		return reviewer;
	}
	public static string getgame(string game)
	{
		return game;
	}
	public static string getReview(string review)
	{
		return review;
	}
	public static int getTimePlayed(int timePlayed)
	{
		return timePlayed;
	}
	public static double getScore(double score)
	{
		return score;
	}
	public void setReviewer(string newReviewer)
	{
		reviewer = newReviewer;
	}
	public void setGame(string newGame)
	{
		game = newGame;
	}
	public void setReview(string newReview)
	{
		review = newReview;
	}
	public void setTimePlayed(int newTimePlayed)
	{
		timePlayed = newTimePlayed;
	}
	public void setScore(double newScore)
	{
		score = newScore;
	}
    public static void generateReview(string reviewer, string game, string review, int timePlayed, double score)
    {
		
		Console.WriteLine($"review by {reviewer}");
		Console.WriteLine($"{game}");
		Console.WriteLine($"{review}");
		Console.WriteLine($"Time Played:{timePlayed}");
		Console.WriteLine($"Final Score: {score}");
		
		
		
    }
	
	
}
