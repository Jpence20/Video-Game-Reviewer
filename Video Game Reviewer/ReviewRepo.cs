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
            Reviews LastOfUsPart1 = new("Luke Reilly", "Last Of Us Part 1", "Amazing", "Playstation 5", 9);
            Reviews Xenoblade3 = new("Travis Northup", "Xenoblade 3", "Great", "Nintendo Switch", 8);
            Reviews TheQuarry = new("Thomas Wilde", "The Quarry", "Good", "PC", 7);
            Reviews EldenRing = new("Mitchell Saltzman", "Elden Ring", "MasterPiece", "PC,Xbox Series X, and Playstation 5", 10);
            Reviews TheLastOfUsPart2 = new("Jonathon Dornbush", "The Last Of Us Part 2", "Masterpiece", "Playstation 4",10);
            Reviews Persona5Royal = new("Leana Hafer", "Persona 5 Royal", "MasterPiece", "Playstation 4", 10);
            Reviews RedDeadRedemption2 = new("Luke Reilly", "Red Dead Redemption2", "MasterPiece", "Playstation 4 and Xbox One", 10);
            Reviews GodOfWar = new("Jonathon Dornbush", "God of War", "Masterpiece", "Playstation 4", 10);
            Reviews Celeste = new("Tom Marks", "Celeste", "MasterPiece", "PC,Xbox One,Playstation 4 , Nintendo Switch", 10);
            Reviews SuperMarioOdyssey = new("Ryan Mcaffrey", "Super Mario Odyssey","MasterPiece", "Nintendo Switch", 10);
            Reviews BreathOfTheWild = new("Jose Otero", "The Legend Of Zelda Breath Of The Wild", "MasterPiece","Nintendo Switch", 10);
            Reviews MetalGearSolid5 = new("Vince Ingenito", "Metal Gear Solid 5 The Phantom Pain", "MasterPiece", "Playstaion 4", 10);
            Reviews GrandTheftAuto5 = new("Keza MacDonald", "Grand Theft Auto 5", "MasterPiece", "Playstation 3 and Xbox 360",10);
            Reviews Bayonetta3 = new("Mithchell Saltzman", "Bayonetta 3", "Amazing", "Nintendo Switch", 9);
            Reviews MarioRabbidsSparksOfHope = new("Dan Stapleton", "Mario + Rabbids", "Amazing", "Nintendo Switch", 9);
            Reviews TotalWarWarhammer3 = new("Leana Hafer", "Total War Warhammer 3", "Amazing", "PC", 9);
            Reviews HorizonForibbenWest = new("Simon Cardy", "Horizon Forbidden West", "Amazing", "Playstation 5", 9);
            Reviews HaloInfinite = new("Ryan Mccaffrey", "Halo Infinite Single Player", "Amazing", "Xbox Series X and PC", 9);
            Reviews MetroidDread = new("Samuel Claiborn", "Metroid Dread", "Amazing", "Nintendo Switch", 9);
            Reviews TalesOfArise = new("Terence Wiggins", "Tales of Arise", "Amazing", "Playstation 5, Xbox Series X, and PC", 9);
            var reviews = new Dictionary<string, Reviews>
        {
            {"Call of Duty Modern Warfare 2", modernWarfare2 },
            {"Gotham Knights", GothamKnights },
            {"A Plague Tale Requiem",PlagueTaleRequim },
            {"Mario + Rabbids Sparks of Hope", SparksofHope },
            {"Overwatch 2",Overwatch2 },
            {"Fifa 23",Fifa23 },
            {"The Last of Us Part 1",LastOfUsPart1 },
            {"Xenoblade 3",Xenoblade3 },
            {"The Quarry",TheQuarry },
            {"Elden Ring",EldenRing },
            {"The Last Of Us Part 2",TheLastOfUsPart2 },
            {"Persona 5 Royal",Persona5Royal },
            {"Red Dead Redemption 2",RedDeadRedemption2 },
            {"God Of War",GodOfWar },
            {"Celeste",Celeste },
            {"Super Mario Odyssey",SuperMarioOdyssey },
            {"The Legend Of Zelda Breath Of The Wild",BreathOfTheWild },
            {"Metal Gear Solid 5 The Phantom Pain",MetalGearSolid5 },
            {"Grand Theft Auto 5",GrandTheftAuto5 },
            {"Bayonetta 3",Bayonetta3 },
            {"Mario + Rabbids Sparks Of Hope",MarioRabbidsSparksOfHope },
            {"Total War Warhammer 3",TotalWarWarhammer3 },
            {"Horizon Forbidden West",HorizonForibbenWest },
            {"Halo Infinite",HaloInfinite },
            {"Metroid Dread",MetroidDread },
            {"Tales Of Arise",TalesOfArise },


        };

            return reviews;
        }
       
        
       

      





    }
}