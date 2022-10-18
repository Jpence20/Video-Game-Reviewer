using VideoGameReviewer;

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
        string input = Console.ReadLine() ?? String.Empty;
        if (input == Jeremy)
        {
            var allReviews = ReviewRepo.InitializeReviews();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            if (select == "1")
            {

                SeeAllReviews.seeReviews1();
                program.selection();
            }
            else if (select == "2")
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
            }

            else if (select == "3")
            {
                program.selection();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Case1();
            }



        }

        else if (input == "2")
        {
            var allReviews = ReviewRepo.InitializeReviewsA();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            if (select == "1")
            {

                SeeAllReviews.seeReviews2();
                program.selection();
            }
            else if (select == "2")
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
            }

            else if (select == "3")
            {
                program.selection();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Case1();
            }
        }

        else if (input == "3")
        {
            var allReviews = ReviewRepo.InitializeReviewsB();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            if (select == "1")
            {

                SeeAllReviews.seeReviews3();
                program.selection();
            }
            else if (select == "2")
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
            }

            else if (select == "3")
            {
                program.selection();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Case1();
            }
        }

        else if (input == "4")
        {
            var allReviews = ReviewRepo.InitializeReviewsC();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine() ?? string.Empty;

            if (select == "1")
            {

                SeeAllReviews.seeReviews4();
                program.selection();
            }
            else if (select == "2")
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
            }

            else if (select == "3")
            {
                program.selection();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Case1();
            }
        }
        else if (input == "5")
        {
            SeeAllReviews.seeAllReviews();
            program.selection();
        }

    }


   

    public static void Case3()
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
    }








}









