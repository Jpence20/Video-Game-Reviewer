using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace Video_Game_Reviewer
{

	public class GameSpotReviewRepo
	{
        public static Dictionary<string, Reviews> GameSpot()
        {
            Reviews godOfWar = new("Jessica Pence", "God of war", "Okay Game", "", 8);
            var reviews = new Dictionary<string, Reviews>
        {
            { "God Of War", godOfWar }
        };
            return reviews;
        }
    }
}