﻿using System;
using videoGameReviewer;

namespace videoGameReviewer
{
   public class program 
    {
        public static String choice;
        
        static void Main(String[] args)
        { 
            
            selection();
           
        }

       public static void selection()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*      Video Game Reviews    *");
            Console.WriteLine("******************************");
            Console.WriteLine("Choose if you want to see a review or write a review");
            Console.WriteLine("1.See Review");
            Console.WriteLine("2.Write Review");
            Console.WriteLine("3.Exit");
            String choice = Console.ReadLine();
            ChoiceSelection(choice);



        }

        public static void ChoiceSelection(string choice)
        {
            switch (choice)
            {
                case "1":
                    {
                       
                        Case1();
                        break;
                    }
                case "2":
                    {
                        
                        Case2();
                        break;
                    }
                case "3":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        selection();
                        return;
                    }
            }
        }
       public static void Case1()
        {
            Console.WriteLine("See Review");
           
       
        }
        public static void Case2()
        {
            Console.WriteLine("Write A Review");

            Console.WriteLine("What is your name?");
            string reviewer = Console.ReadLine();
            VGameReviewer.getreviewer(reviewer);

            Console.WriteLine("What is the name of the game you are reviewing?");
            string game = Console.ReadLine();
            VGameReviewer.getgame(game);

            Console.WriteLine("What is your review of the game?");
            string review = Console.ReadLine();
            VGameReviewer.getReview(review);

            Console.WriteLine("How long did you play the game?");
            int timePlayed = int.Parse(Console.ReadLine());
            VGameReviewer.getTimePlayed(timePlayed);

            Console.WriteLine("What is your score for the game out of 10?");
            double score = double.Parse(Console.ReadLine());
            VGameReviewer.getScore(score);


            VGameReviewer.generateReview( reviewer,game,review,timePlayed,score);
            selection();
        }


       

    }

   














}




