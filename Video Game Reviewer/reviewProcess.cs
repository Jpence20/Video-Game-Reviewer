using System;

public class VideoGameReviewer
{
	string reviewer;
	string game;
	string review;
	int timePlayed;
	double score;

	public void GameReviewer(string reviewer, string game, string review, int timePlayed,double score)
	{
		this.reviewer = reviewer;
		this.game = game;
		this.review = review;
		this.timePlayed = timePlayed;
		this.score = score;
	}
	public string getreviewer()
	{
		return reviewer;
	}
	public string getgame()
	{
		return game;
	}
	public string getReview()
	{
		return review;
	}
	public int getTimePlayed()
	{
		return timePlayed;
	}
	public double getScore()
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
}
