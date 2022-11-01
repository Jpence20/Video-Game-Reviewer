using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace Video_Game_Reviewer
{
    public class ReviewRepo
    {



        public static Dictionary<string, Reviews> IGNReviews()
        {


            Reviews modernWarfare2 = new("Matt Purslow", "Call of Duty Modern Warfare 2", "Great Game", "Playstation 5", 6);
            Reviews GothamKnights = new("Travis Northup", "Gotham Knights", "Amazing Game", "Xbox Series X", 5);
            Reviews PlagueTaleRequim = new("Travis Northup", "A Plague Tale Requiem", "Once in a generetion Game", "Xbox Series X", 8);
            Reviews SparksofHope = new("Dan Stapleton", "Mario + Rabbids: Sparks of Hope", "Great Game", "Nitendo Switch", 9);
            Reviews Overwatch2 = new("Simon Cardy", "Overwatch 2", "okay", "All Platforms", 8);
            Reviews Fifa23 = new("Jordan Oloman", "Fifa 23", "Good", "PC, Playstation 5 and Xbox Series X", 7);

            var reviews = new Dictionary<string, Reviews>
        {
            { "Call of Duty Modern Warfare 2", modernWarfare2 },
            { "Gotham Knights", GothamKnights },
            {"A Plague Tale Requiem",PlagueTaleRequim },
            {"Mario + Rabbids Sparks of Hope", SparksofHope },
            {"OverWatch 2",Overwatch2 },
            {"Fifa 23",Fifa23 },

        };

            return reviews;
        }
        public static Dictionary<string, Reviews> EasyAllies()
        {
            Reviews godOfWar = new("John Pence", "God of war", "Great Game", "", 10);
            var reviews = new Dictionary<string, Reviews>
        {
            { "god of war-a", godOfWar }
        };
            return reviews;
        }
        public static Dictionary<string, Reviews> GameSpot()
        {
            Reviews godOfWar = new("Jessica Pence", "God of war", "Okay Game", "", 8);
            var reviews = new Dictionary<string, Reviews>
        {
            { "god of war-b", godOfWar }
        };
            return reviews;
        }
        public static Dictionary<string, Reviews> AngryJoe()
        {
            Reviews godOfWar = new("Brian Maggard", "God of war", "Great Game", "", 10);
            var reviews = new Dictionary<string, Reviews>
        {
            { "god of war-c", godOfWar }
        };

            return reviews;
        }

        private static readonly Dictionary<string, WrittenReviews> dictionary = new();
        public static readonly Dictionary<string, WrittenReviews>? Wreview = dictionary;





    }
}