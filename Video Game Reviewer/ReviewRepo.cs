using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace Video_Game_Reviewer
{
    public class ReviewRepo
    {



        public static Dictionary<string, Reviews> IGNReviews()
        {


            Reviews godOfWar = new("Jeremy Pence", "God of war", "Great Game", 40, 10);
            Reviews persona5 = new("Jeremy Pence", "Persona 5", "Amazing Game", 100, 10);
            Reviews lastofUs = new("Jeremy Pence", "Last of Us", "Once in a generetion Game", 30, 10);

            var reviews = new Dictionary<string, Reviews>
        {
            { "god of war", godOfWar },
            { "Persona 5", persona5 },
            {"Last of Us",lastofUs }

        };

            return reviews;
        }
        public static Dictionary<string, Reviews> EasyAllies()
        {
            Reviews godOfWar = new("John Pence", "God of war", "Great Game", 40, 10);
            var reviews = new Dictionary<string, Reviews>
        {
            { "god of war-a", godOfWar }
        };
            return reviews;
        }
        public static Dictionary<string, Reviews> GameSpot()
        {
            Reviews godOfWar = new("Jessica Pence", "God of war", "Okay Game", 40, 8);
            var reviews = new Dictionary<string, Reviews>
        {
            { "god of war-b", godOfWar }
        };
            return reviews;
        }
        public static Dictionary<string, Reviews> AngryJoe()
        {
            Reviews godOfWar = new("Brian Maggard", "God of war", "Great Game", 60, 10);
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