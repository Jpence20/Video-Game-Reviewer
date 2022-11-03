using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;


namespace Video_Game_Reviewer
{
    public class EasyAlliesReviewsRepo
    {
        public static Dictionary<string, Reviews> EasyAllies()
        {
            Reviews godOfWar = new("John Pence", "God of war", "Great Game", "", 10);
            var reviews = new Dictionary<string, Reviews>
        {
            { "god of war-a", godOfWar }
        };
            return reviews;
        }
    }
}