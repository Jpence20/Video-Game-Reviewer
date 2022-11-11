using VideoGameReviewer;

namespace Video_Game_Reviewer
{
    public class Case : WriteReview
    {

        //logic for navigating the see reviews section
        public static void Case1()
        {

            Console.WriteLine("Who do you want to see reviews from?");
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.IGN");
            Console.WriteLine("2.Easy Allies");
            Console.WriteLine("3.GameSpot");
            Console.WriteLine("4.AngryJoe");
            Console.WriteLine("5.See My reviews");
            string IGN = "1";
            string EasyAllies = "2";
            string GameSpot = "3";
            string AngryJoe = "4";
            string seeMyReviews = "5";
            string Exit = "0";

            string input = Console.ReadLine() ?? string.Empty;
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
                        SeeAllReviews.SeeAllIgnReviews();
                        Program.Selection();
                        break;
                    case "2":
                        {
                            Console.WriteLine("What review do you want to read?");
                            string name = Console.ReadLine() ?? string.Empty;


                            bool success = allReviews.ContainsKey(name);

                            if (success)
                            {
                                Console.WriteLine($"The review you ask for is \r\n {allReviews[name]}");
                                Program.Selection();
                            }
                            else
                            {
                                Console.WriteLine($"There is no review named {name}");
                                Program.Selection();
                            }

                            break;
                        }

                    case "3":
                        Program.Selection();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        Case1();
                        break;
                }



            }

            else if (input == EasyAllies)
            {
                var allReviews = EasyAlliesReviewsRepo.EasyAllies();


                Console.WriteLine("Do you want to see all reviews or chose one to see");
                Console.WriteLine("1.See all Reviews");
                Console.WriteLine("2.Find a review");
                Console.WriteLine("3.Exit");
                string select = Console.ReadLine() ?? string.Empty;

                switch (select)
                {
                    case "1":
                        SeeAllReviews.SeeAllEasyAlliesReviews();
                        Program.Selection();
                        break;
                    case "2":
                        {
                            Console.WriteLine("What review do you want to read?");
                            string name = Console.ReadLine() ?? string.Empty;


                            bool success = allReviews.ContainsKey(name);

                            if (success)
                            {
                                Console.WriteLine($"The review you ask for is {allReviews[name]}");
                                Program.Selection();
                            }
                            else
                            {
                                Console.WriteLine($"There is no review named {name}");
                                Program.Selection();
                            }

                            break;
                        }

                    case "3":
                        Program.Selection();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Case1();
                        break;
                }
            }

            else if (input == GameSpot)
            {
                var allReviews = GameSpotReviewRepo.GameSpot();


                Console.WriteLine("Do you want to see all reviews or chose one to see");
                Console.WriteLine("1.See all Reviews");
                Console.WriteLine("2.Find a review");
                Console.WriteLine("3.Exit");
                string select = Console.ReadLine() ?? string.Empty;

                switch (select)
                {
                    case "1":
                        SeeAllReviews.SeeAllGameSpotReviews();
                        Program.Selection();
                        break;
                    case "2":
                        {
                            Console.WriteLine("What review do you want to read?");
                            string name = Console.ReadLine() ?? string.Empty;


                            bool success = allReviews.ContainsKey(name);

                            if (success)
                            {
                                Console.WriteLine($"The review you ask for is {allReviews[name]}");
                                Program.Selection();
                            }
                            else
                            {
                                Console.WriteLine($"There is no review named {name}");
                                Program.Selection();
                            }

                            break;
                        }

                    case "3":
                        Program.Selection();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Case1();
                        break;
                }
            }

            else if (input == AngryJoe)
            {
                var allReviews = AngryJoeReviewRepo.AngryJoe();


                Console.WriteLine("Do you want to see all reviews or chose one to see");
                Console.WriteLine("1.See all Reviews");
                Console.WriteLine("2.Find a review");
                Console.WriteLine("3.Exit");
                string select = Console.ReadLine() ?? string.Empty;

                switch (select)
                {
                    case "1":
                        SeeAllReviews.SeeAllAngryJoeReviews();
                        Program.Selection();
                        break;
                    case "2":
                        {
                            Console.WriteLine("What review do you want to read?");
                            string name = Console.ReadLine() ?? string.Empty;


                            bool success = allReviews.ContainsKey(name);

                            if (success)
                            {
                                Console.WriteLine($"The review you ask for is {allReviews[name]}");
                                Program.Selection();
                            }
                            else
                            {
                                Console.WriteLine($"There is no review named {name}");
                                Program.Selection();
                            }

                            break;
                        }

                    case "3":
                        Program.Selection();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Case1();
                        break;
                }
            }
            else if (input == Exit)
            {
                Program.Selection();
            }
            else if (input == seeMyReviews)
            {
                SeeAllReviews.MyReviews();
                Program.Selection();


            }

        }
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


















