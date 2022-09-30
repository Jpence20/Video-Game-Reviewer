using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using videoGameReviewer;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.CompilerServices;

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


		AddGames(reviewer,game,review,timePlayed,score);
		
		
		
    }
	

	public static void AddGames(string reviewer,string game,string review,int timepLayed,double score)
	{
	
	
      
	}

	public static List<VGameReviewer> InitializeGames()
	{
		List<VGameReviewer> games = new List<VGameReviewer>();
		
       games.Add( new VGameReviewer("jeremy Pence", "God of war", "Great game!", 40, 10));
        games.Add(new VGameReviewer("jeremy Pence", "Persona 5", "Great game!", 100, 10));
		
		return games;
      


   
	}
	
}
