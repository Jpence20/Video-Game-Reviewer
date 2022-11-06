using System;
using VideoGameReviewer;

namespace Video_Game_Reviewer
{
	public class WriteGameToListAndViewList
	{

        public static void ViewOrWriteGamesToList()
        {
            Console.WriteLine("1.Write Game Into List");
            Console.WriteLine("2.See List");
            Console.WriteLine("3.Exit");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    {
                        GetGameListValues.GetValues();
                        Program.Selection();
                        break;
                    }
                case "2":
                    {
                        SeeAllReviews.MyGamesListOrder();
                        Program.Selection();
                        break;
                    }
            }

        }
    }
}