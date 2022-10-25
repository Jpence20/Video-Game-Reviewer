using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;

public class ReviewRepo 
{



    public static Dictionary<string, reviews> IGNReviews()
    {


        reviews godOfWar = new reviews("Jeremy Pence", "God of war", "Great Game", 40, 10);
        reviews persona5 = new reviews("Jeremy Pence", "Persona 5", "Amazing Game", 100, 10);
        reviews lastofUs = new reviews("Jeremy Pence", "Last of Us", "Once in a generetion Game", 30, 10);

        var reviews = new Dictionary<string, reviews>
        {
            { "god of war", godOfWar },
            { "Persona 5", persona5 },
            {"Last of Us",lastofUs }

        };

        return reviews;
    }
    public static Dictionary<string, reviews> EasyAllies()
    {
        reviews godOfWar = new reviews("John Pence", "God of war", "Great Game", 40, 10);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war-a", godOfWar }
        };
        return reviews;
    }
    public static Dictionary<string, reviews> GameSpot()
    {
        reviews godOfWar = new reviews("Jessica Pence", "God of war", "Okay Game", 40, 8);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war-b", godOfWar }
        };
        return reviews;
    }
    public static Dictionary<string, reviews> AngryJoe()
    {
        reviews godOfWar = new reviews("Brian Maggard", "God of war", "Great Game", 60, 10);
        var reviews = new Dictionary<string, reviews>
        {
            { "god of war-c", godOfWar }
        };

        return reviews;
    }



    public  static Dictionary<string, WrittenReviews>? Wreview= new Dictionary<string, WrittenReviews>();
    

      
       
    
}

