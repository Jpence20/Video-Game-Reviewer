using VideoGameReviewer;

public class Case
{


    public static void Case1()
    {

        Console.WriteLine("Who do you want to see reviews from?");
        Console.WriteLine("0.Exit");
        Console.WriteLine("1.IGN");
        Console.WriteLine("2.Easy Allies");
        Console.WriteLine("3.GameSpot");
        Console.WriteLine("4.AngryJoe");
        Console.WriteLine("5.See all Reviews");
        Console.WriteLine("6.See My reviews");
        string IGN = "1";
        string EasyAllies = "2";
        string GameSpot = "3";
        string AngryJoe = "4";
        string seeAllReviews = "5";
        string seeMyReviews = "6";
        string Exit = "0";
        
        string input = Console.ReadLine() ?? String.Empty;
        if (input == IGN)
        {
            var allReviews = ReviewRepo.IGNReviews();



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

        else if (input == EasyAllies)
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

        else if (input == GameSpot)
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

        else if (input == AngryJoe)
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
        else if (input == seeMyReviews) 
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


















