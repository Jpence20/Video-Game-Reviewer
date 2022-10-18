﻿using VideoGameReviewer;

public class Case
{


    public static void Case1()
    {

        Console.WriteLine("Who do you want to see reviews from?");
        Console.WriteLine("0.Exit");
        Console.WriteLine("1.Jeremy");
        Console.WriteLine("2.John");
        Console.WriteLine("3.Jessica");
        Console.WriteLine("4.Brian");
        Console.WriteLine("5.See all Reviews");
        string Jeremy = "1";
        string John = "2";
        string Jessica = "3";
        string Brian = "4";
        string seeAllReviews = "5";
        string Exit = "0";
        
        string input = Console.ReadLine() ?? String.Empty;
        if (input == Jeremy)
        {
            var allReviews = ReviewRepo.InitializeReviews();



            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            switch (select)
            {
                case "1":
                    SeeAllReviews.seeReviews1();
                    program.selection();
                    break;
                case "2":
                    {
                        Console.WriteLine("What review do you want to read?");
                        string name = Console.ReadLine() ?? string.Empty;


                        bool success = allReviews.ContainsKey(name);

                        if (success)
                        {
                            Console.WriteLine($"The review you ask for is {allReviews[name]}");
                            program.selection();
                        }
                        else
                        {
                            Console.WriteLine($"There is no review named {name}");
                            program.selection();
                        }

                        break;
                    }

                case "3":
                    program.selection();
                    break;
                case "4":
                    {
                        Console.WriteLine("Select a score for 1-10 to see all reviews with that score");
                        string score = Console.ReadLine();

                        switch (score)
                        {
                            case "10":
                                {
                                    SeeAllReviews.scoreSearching();
                                    program.selection();
                                    break;
                                }
                        }

                        break;
                    }

                default:
                    Console.WriteLine("Invalid Input");
                    Case1();
                    break;
            }



        }

        else if (input == John)
        {
            var allReviews = ReviewRepo.InitializeReviewsA();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            switch (select)
            {
                case "1":
                    SeeAllReviews.seeReviews2();
                    program.selection();
                    break;
                case "2":
                    {
                        Console.WriteLine("What review do you want to read?");
                        string name = Console.ReadLine() ?? string.Empty;


                        bool success = allReviews.ContainsKey(name);

                        if (success)
                        {
                            Console.WriteLine($"The review you ask for is {allReviews[name]}");
                            program.selection();
                        }
                        else
                        {
                            Console.WriteLine($"There is no review named {name}");
                            program.selection();
                        }

                        break;
                    }

                case "3":
                    program.selection();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Case1();
                    break;
            }
        }

        else if (input == Brian)
        {
            var allReviews = ReviewRepo.InitializeReviewsB();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            switch (select)
            {
                case "1":
                    SeeAllReviews.seeReviews3();
                    program.selection();
                    break;
                case "2":
                    {
                        Console.WriteLine("What review do you want to read?");
                        string name = Console.ReadLine() ?? string.Empty;


                        bool success = allReviews.ContainsKey(name);

                        if (success)
                        {
                            Console.WriteLine($"The review you ask for is {allReviews[name]}");
                            program.selection();
                        }
                        else
                        {
                            Console.WriteLine($"There is no review named {name}");
                            program.selection();
                        }

                        break;
                    }

                case "3":
                    program.selection();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Case1();
                    break;
            }
        }

        else if (input == Jessica)
        {
            var allReviews = ReviewRepo.InitializeReviewsC();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            switch (select)
            {
                case "1":
                    SeeAllReviews.seeReviews4();
                    program.selection();
                    break;
                case "2":
                    {
                        Console.WriteLine("What review do you want to read?");
                        string name = Console.ReadLine() ?? string.Empty;


                        bool success = allReviews.ContainsKey(name);

                        if (success)
                        {
                            Console.WriteLine($"The review you ask for is {allReviews[name]}");
                            program.selection();
                        }
                        else
                        {
                            Console.WriteLine($"There is no review named {name}");
                            program.selection();
                        }

                        break;
                    }

                case "3":
                    program.selection();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Case1();
                    break;
            }
        }
        else if (input == seeAllReviews)
        {
            SeeAllReviews.seeAllReviews();
            program.selection();
        }
        else if (input == Exit)
        {
            program.selection();
        }
        else if (input == "6") 
        {
            SeeAllReviews.myReviews();
            program.selection();
           

        }

    }

    public static WrittenReviews saveReview() 
    {
         
        
        string reviewer = makeReview.getReviewer();
        string game = makeReview.getGame();
        string review = makeReview.getReview();
        int timePlayed = makeReview.getTimePlayed();
        double score = makeReview.getScore();
        
        WrittenReviews newReview = new WrittenReviews($"{reviewer}", $"{game}", $"{review}", timePlayed, score);



        ReviewRepo.Wreview.Add(game, newReview);

        return newReview;

    }
}





    /*public static void Case3()
    {
        string input = Console.ReadLine() ?? string.Empty;
        if (input == "1")
        {
            var result = ReviewRepo.scoreSearch()
            .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

            foreach (reviews review in result.Values)
            {
                Console.WriteLine($"{review}");
            }
        }
    }*/


















