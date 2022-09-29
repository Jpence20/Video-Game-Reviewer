using System;
using System.Xml.Schema;
using videoGameReviewer;

public class VGameReviewer
{
	public string reviewer { get; set; }
	public string game { get; set; }
	public string review { get; set; }
	public int timePlayed { get; set; }
	public double score { get; set; }
	public VGameReviewer(string reviewer, string game, string review, int timePlayed, double score)
	{
		this.reviewer = reviewer;
		this.game = game;
		this.review = review;
		this.timePlayed = timePlayed;
		this.score = score;
	}
	public override string ToString()=>$"\r\nReviewed by {reviewer}:\r\n {game}\r\n {review}\r\n Time Played:{timePlayed}\r\n Final Score:{score}\r\n";



	public static void generateReview(string reviewer, string game, string review, int timePlayed, double score)
    {
		
		Console.WriteLine($"Reviewed by {reviewer}");
		Console.WriteLine($"{game}");
		Console.WriteLine($"{review}");
		Console.WriteLine($"Time Played:{timePlayed}");
		Console.WriteLine($"Final Score: {score}");
		
		
		
    }

	public static void reviews()
	{
		VGameReviewer godOfWar = new VGameReviewer("jeremy Pence", "God of war", "Great game!", 40, 10);
		Console.WriteLine(godOfWar);
	}
	
}
