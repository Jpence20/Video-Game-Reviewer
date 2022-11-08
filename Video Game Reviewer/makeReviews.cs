using VideoGameReviewer;
using System;
using System.Text.RegularExpressions;

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
            Console.WriteLine("If you are Writing a Review choose 1, if you are adding a game to a list select 2");
            string selection = Console.ReadLine() ?? string.Empty;

            switch (selection)
            {
                case "1":
                    {
                        Console.WriteLine("What is your score for the game out of 10");
                        if (double.TryParse(Console.ReadLine(), out double score))
                        {
                            return score;
                        }
                        Console.WriteLine("Please Enter a Valid Number");
                        return GetScore();
                    }
                case "2":
                    {
                        Console.WriteLine("What is your score out of 10 for the game so far?");
                        if (double.TryParse(Console.ReadLine(), out double score))
                        {
                            return score;
                        }
                        Console.WriteLine("Please Enter a Valid Number");
                        return GetScore();
                    }
         
                default:
                    Console.WriteLine("Invalid Input");
                   return GetScore();
                    
            }

           
        }

        public static string GetDate()
        {
           Console.WriteLine("When day did you beat this game? Please enter in dd/mm/year format");
           Regex validateDate = new Regex("^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");

            string dateWritten = Console.ReadLine() ?? string.Empty;

            if (Regex.Match(dateWritten, "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$").Success)
            {
                return dateWritten;
            }
            else
                Console.WriteLine("Please Enter in Correct date format");
                return GetDate();
                    
                

          
        }

        public static string GetStartDate()
        {
            Console.WriteLine("What date did you start this game? Please enter in dd/mm/year format");
            Regex validateDate = new Regex("^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");

            string dateStarted = Console.ReadLine() ?? string.Empty;
            if (Regex.Match(dateStarted, "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$").Success)
            {
                return dateStarted;
            }
            else
                Console.WriteLine("Please Enter in Correct date format");
            return GetStartDate();
        }

    }
}