using System;

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
                        
                        Console.WriteLine($"See Review");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Write Review");
                        break;
                    }
                case "3":
                    {
                        break;
                    }
                default:
                    {

                        break;
                    }
            }
        }
        public static void Case1()
        {
            Console.WriteLine("See Review");
        }

    }
















}





