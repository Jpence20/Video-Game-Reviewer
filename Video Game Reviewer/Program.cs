namespace VideoGameReviewer
{

    public class program
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

                            Case.saveReview();
                            selection();
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    default:
                        {
                            selection();
                            throw new ApplicationException("Unkown status:" + choice);

                        }
                }
            }


        }



    }
}













