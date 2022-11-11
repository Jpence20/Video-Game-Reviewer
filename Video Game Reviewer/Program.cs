using Video_Game_Reviewer;

namespace VideoGameReviewer
{

    public class Program
    {
       public static void Main(string[] args )
        {
            Selection();
        }

        public static void Selection()
        {

            Console.WriteLine("******************************");
            Console.WriteLine("*      Video Game Reviews    *");
            Console.WriteLine("******************************");
            Console.WriteLine("Choose if you want to see a review or write a review");
            Console.WriteLine("1.See Review");
            Console.WriteLine("2.Write Review");
            Console.WriteLine("3.Make or see Game List");
            Console.WriteLine("Press any key to except 1,2 or 3 to Exit");
            String choice = Console.ReadLine() ?? string.Empty;
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

                            WriteReview.SaveReview();
                            Selection();
                            break;
                        }
                    case "3":
                        {
                            WriteGameToListAndViewList.ViewOrWriteGamesToList();
                            Selection();
                            break;
                        }
                   
                     
                   
                }
            }


        }



    }
}













