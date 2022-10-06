using System;
using System.ComponentModel.Design;

namespace VideoGameReviewer
{

    public class program
    {
        static void Main(string[] args)
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


            static void ChoiceSelection(string choice)
            {
                switch (choice)
                {
                    case "1":
                        {

                           Case.Case1();
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
           

        }
        public static void Case2()
        {
            Console.WriteLine("What is your name?");
            string reviewer = Console.ReadLine();
            Console.WriteLine("What is the name of the game you want to review");
            string game = Console.ReadLine();
            Console.WriteLine("Write out your review.");
            string review = Console.ReadLine();
            Console.WriteLine("How many hours did you play");
            int timePlayed = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your score for the game out of 10");
            double score = double.Parse(Console.ReadLine());

           var Allreviews = ReviewRepo.WReview(reviewer, game, review, timePlayed, score);
            foreach (WrittenReviews reviews in Allreviews.Values)
            {
                Console.WriteLine(reviews);

            }
            program.selection();

        }


    }
}













