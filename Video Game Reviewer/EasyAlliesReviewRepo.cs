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
            Reviews RedDeadRedemtion2 = new("Brandon Jones", "Red Dead Redemption 2", "Rockstar achieves a new level of open world immersion in the second chapter of their wild west epic. Big choices lead to surprising consequences, and lots of customization options generate an attachment to your surroundings. Incredible visuals and spontaneous events create a beautiful, breathing world to explore.", "Playstion 4 Pro", 10);
            Reviews GodOfWar = new("Michael Huber", "God Of War", "God of War reinvents the franchise with deep combat and rewarding exploration.", "Playstation 4 Pro", 10);
            var reviews = new Dictionary<string, Reviews>
        {
            { "Red Dead Redemption 2",RedDeadRedemtion2  },
            {"God Of War",GodOfWar },
        };
            return reviews;
        }
    }
}