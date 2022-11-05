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
            Console.WriteLine("3.Make Game List");
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
                            Console.WriteLine("1.Write Game Into List");
                            Console.WriteLine("2.See List");
                            Console.WriteLine("3.Exit");
                            string selection = Console.ReadLine();


                            GetGameListValues.GetValues();
                            Selection();
                            break;
                        }
                    case "4":
                        {

                            break;
                        }
                     
                    default:
                        {
                            Selection();
                            throw new ApplicationException("Unkown status:" + choice);

                        }
                }
            }


        }



    }
}













