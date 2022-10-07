using System;
using System.Security.Cryptography.X509Certificates;
using VideoGameReviewer;
using static System.Formats.Asn1.AsnWriter;

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

        string input = Console.ReadLine();
        if (input == "1")
        {
            var allReviews = ReviewRepo.InitializeReviews();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine();

            if (select == "1")
            {

                foreach (reviews review in allReviews.Values)
                {
                    Console.WriteLine(review);

                }
                program.selection();
            }
            else if (select == "2")
            {
                Console.WriteLine("What review do you want to read?");
                string name = Console.ReadLine();


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
            string select = Console.ReadLine();

            if (select == "1")
            {

                foreach (reviews review in allReviews.Values)
                {
                    Console.WriteLine(review);

                }
                program.selection();
            }
            else if (select == "2")
            {
                Console.WriteLine("What review do you want to read?");
                string name = Console.ReadLine();


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
            string select = Console.ReadLine();

            if (select == "1")
            {

                foreach (reviews review in allReviews.Values)
                {
                    Console.WriteLine(review);

                }
                program.selection();
            }
            else if (select == "2")
            {
                Console.WriteLine("What review do you want to read?");
                string name = Console.ReadLine();


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
            string select = Console.ReadLine();

            if (select == "1")
            {

                foreach (reviews review in allReviews.Values)
                {
                    Console.WriteLine(review);

                }
                program.selection();
            }
            else if (select == "2")
            {
                Console.WriteLine("What review do you want to read?");
                string name = Console.ReadLine();


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
            var allReviews = ReviewRepo.Wreview();


            Console.WriteLine("Do you want to see all reviews or chose one to see");
            Console.WriteLine("1.See all Reviews");
            Console.WriteLine("2.Find a review");
            Console.WriteLine("3.Exit");
            string select = Console.ReadLine();

            if (select == "1")
            {

                foreach (WrittenReviews review in allReviews.Values)
                {
                    Console.WriteLine(review);

                }
                program.selection();
            }
            else if (select == "2")
            {
                Console.WriteLine("What review do you want to read?");
                string name = Console.ReadLine();


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
    }


   public static void Case2()
    {
        var result = ReviewRepo.InitializeReviews().Union(ReviewRepo.InitializeReviewsA()).Union(ReviewRepo.InitializeReviewsB()).Union(ReviewRepo.InitializeReviewsC())
            .GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);

       foreach(reviews review in result.Values)
        {
             Console.WriteLine(review);
        }
    }










}
        
       
        

       
    



