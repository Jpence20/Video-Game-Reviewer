using System;
using System.ComponentModel.Design;

namespace VideoGameReviewer
{

    public class prgroam
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

                            case1();
                            break;
                        }
                    case "2":
                        {

                           
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

        public static void case1()
        {
            Console.WriteLine("Who do you want to see reviews from select 1 for jeremy, and 2 for john");
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
                selection();
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
                selection();
            }
                    

            

           

          
        }
    }
}