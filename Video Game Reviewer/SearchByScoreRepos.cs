public class SearchByScoreRepos
{
    public static Dictionary<string, reviews> ScoreSearch10()
    {


        reviews godOfWar = new reviews("Jeremy Pence", "God of war", "Great Game", 40, 10);
        reviews persona5 = new reviews("Jeremy Pence", "Persona 5", "Amazing Game", 100, 10);

        var reviews = new Dictionary<string, reviews>
        {
            { "god of war", godOfWar },
            { "Persona 5", persona5 }

        };

        return reviews;
    }
}