using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace Video_Game_Reviewer
{

    public class AngryJoeReviewRepo
    {
        public static Dictionary<string, Reviews> AngryJoe()
        {
            Reviews godOfWar = new("Brian Maggard", "God of war", "Great Game", "", 10);
            var reviews = new Dictionary<string, Reviews>
        {
            { "God Of War", godOfWar }
        };

            return reviews;
        }
    }
}