﻿using System;
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

        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            var allReviews = ReviewRepo.InitializeReviews();
            Console.WriteLine("What review do you want to read?");
            string name = Console.ReadLine();
            reviews answer = allReviews[name];
            if (answer != null)
            {
                Console.WriteLine($"The review you ask for is {answer}");
            }
            else
            {
                Console.WriteLine($"There is no review named {name}");
            }
            prgroam.selection();
           
        }

        else if (input == 2)
        {
            var allReviews = ReviewRepo.InitializeReviewsA();
            Console.WriteLine("What review do you want to read?");
            string name = Console.ReadLine();
            reviews answer = allReviews[name];
            if (answer != null)
            {
                Console.WriteLine($"The review you ask for is {answer}");
            }
            else
            {
                Console.WriteLine($"There is no review named {name}");
            }
            prgroam.selection();
        }

        else if (input == 3)
        {
            var allReviews = ReviewRepo.InitializeReviewsB();
            Console.WriteLine("What review do you want to read?");
            string name = Console.ReadLine();
            reviews answer = allReviews[name];
            if (answer != null)
            {
                Console.WriteLine($"The review you ask for is {answer}");
            }
            else
            {
                Console.WriteLine($"There is no review named {name}");
            }
            prgroam.selection();
        }

        else if (input == 4)
        {
            var allReviews = ReviewRepo.InitializeReviewsC();
            Console.WriteLine("What review do you want to read?");
            string name = Console.ReadLine();
            reviews answer = allReviews[name];
            if (answer != null)
            {
                Console.WriteLine($"The review you ask for is {answer}");
            }
            else
            {
                Console.WriteLine($"There is no review named {name}");
            }
            prgroam.selection();
        }

        else if (input == 0)
        {
            prgroam.selection();
        }








    }
}
